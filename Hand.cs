using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    public class Hand
    {

        #region Private Members
        List<Card> _Cards = null;
        List<Card> _SCards = null;

        #endregion

        #region Public Properties
        public Card Deal
        {
            set
            {
                value.Bouncable = false;
                value.Holdable = true;
                _Cards.Add(value);
                _SCards.Add(value);
            }
        }
        #endregion

        #region  Private Methods 
        private void Sort()
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < (_SCards.Count - 1); i++)
                {
                    if (_SCards[i].Value > _SCards[i + 1].Value)
                    {
                        Card temp = _SCards[i];
                        _SCards[i] = _SCards[i + 1];
                        _SCards[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);                         
         }
        public bool RoyalFlush()
        {
            bool result = false;
            if ((_SCards[0].Value == 1) && (_SCards[1].Value == 10) && (_SCards[2].Value == 11) && (_SCards[3].Value == 12) && (_SCards[4].Value == 13) && (_SCards[0].Suit == _SCards[1].Suit) && (_SCards[1].Suit == _SCards[2].Suit) &&
                (_SCards[2].Suit == _SCards[3].Suit) && (_SCards[3].Suit == _SCards[4].Suit))
            {
                result = true;
            }
            return result;
        }
        public bool StraightFlush()
        {
            bool result = false;
            if (Straight() == true && Flush() == true)
            {
                result = true;
            }
            return result;
        }
        public bool FourofaKind()
        {
            bool result = false;
            if (_SCards[0].Value == _SCards[1].Value && _SCards[1].Value == _SCards[2].Value && _SCards[2].Value == _SCards[3].Value)
            {
                result = true;
            }
            return result;
        }
        public bool BobSaget()
        {
            bool result = false;
            if (_SCards[0].Value == _SCards[1].Value && _SCards[1].Value == _SCards[2].Value && _SCards[3].Value == _SCards[4].Value)
            {
                result = true;
            }
            else if (_SCards[0].Value == _SCards[1].Value && _SCards[2].Value == _SCards[3].Value && _SCards[3].Value == _SCards[4].Value)
            {
                result = true;
            }
            return result;
        }
        public bool Flush()
        {
            bool result = false;
            if ((_SCards[0].Suit == _SCards[1].Suit) && (_SCards[1].Suit == _SCards[2].Suit) &&
                (_SCards[2].Suit == _SCards[3].Suit) && (_SCards[3].Suit == _SCards[4].Suit))
            {
                result = true;
            }
                return result;
        }
        public bool Straight()
        {
            bool result = false;
            if ((_SCards[0].Value + 1 == _SCards[1].Value) && (_SCards[1].Value + 1 == _SCards[2].Value) &&
                (_SCards[2].Value + 1 == _SCards[3].Value) && (_SCards[3].Value + 1 == _SCards[4].Value))
            {
                result = true;
            }
            return result;
        }
        public bool ThreeofaKind()
        {
            bool result = false;
            if (_SCards[0] == _SCards[1] && _SCards[1] == _SCards[2])
            {
                result = true;
            }
            else if (_SCards[1] == _SCards[2] && _SCards[2] == _SCards[3])
            {
                result = true;
            }
            else if (_SCards[2] == _SCards[3] && _SCards[3] == _SCards[4])
            {
                result = true;
            }
            return result;
        }
        public bool TwoPair()
        {
            bool result = false;
            if (_SCards[0] == _SCards[1] && _SCards[2] == _SCards[3])
            {
                result = true;
            }
            else if (_SCards[0] == _SCards[1] && _SCards[3] == _SCards[5])
            {
                result = true;
            }
            else if (_SCards[1] == _SCards[2] && _SCards[3] == _SCards[4])
            {
                result = true;
            }
            return result;
        }
        public bool Pair()
        {
            bool result = false;
            if (_SCards[0].Value == _SCards[1].Value)
            {
                result = true;
            }
            else if (_SCards[1].Value == _SCards[2].Value)
            {
                result = true;
            }
            else if (_SCards[2].Value == _SCards[3].Value)
            {
                result = true;
            }
            else if (_SCards[3].Value == _SCards[4].Value)
            {
                result = true;
            }
            if (_SCards[4].Value == _SCards[5].Value)
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region  Public Methods 
        public void Draw(Deck deck)
        {
            for (int i = 0; i < _Cards.Count; i++)
            {
                if (_Cards[i].IsHeld == false)
                {
                    _Cards[i].Dispose();
                    _Cards[i] = deck.Deal();                   
                }
                _Cards[i].Holdable = false;
            }
            _SCards.Clear();
            foreach (Card card in _Cards)
            {
                _SCards.Add(card);
            }
        }
        public void Show()
        {
            int x = 200;
            int y = 500;
            foreach (Card card in _Cards)
            {
                card.Flip();
                Point location = new Point(x, y);
                card.pbCard.Location = location;
                x += (card.pbCard.Width + 2);
            }
        }
        public void Dispose()
        {
            foreach (Card card in _Cards)
            {
                card.Dispose();
                Application.DoEvents();
            }
        }
        public string Evaluate()
        {
            Sort();

            string result = string.Empty;
            if (RoyalFlush() == true)
            {
                result = "Royal Flush";
            }
            else if (StraightFlush() == true)
            {
                result = "Straight Flush";
            }
            else if (FourofaKind() == true)
            {
                result = "Four of a kind";
            }
            else if (BobSaget() == true)
            {
                result = "Full House";
            }
            else if (Flush() == true)
            {
                result = "Flush";
            }
            else if (Straight() == true)
            {
                result = "Straight";
            }
            else if (ThreeofaKind() == true)
            {
                result = "Three of a kind";
            }
            else if (TwoPair() == true)
            {
                result = "Two Pair";
            }
            else if (Pair() == true)
            {
                result = "Pair";
            }
            else
            {
                result = "High Card";
            }
            return result;           
        }

        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public Hand()
        {
            _Cards = new List<Card>();
            _SCards = new List<Card>();
        }
        #endregion

    }
}
