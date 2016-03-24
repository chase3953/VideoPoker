using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    class Deck
    {

        #region Private Members
        private string[] _Suits = {"D", "S", "C", "H"};
        private uint[] _Values = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        private List<Card> _Cards;
        private Queue<Card> _Shoe;
        private Form _Form;
        private Random _rnd;

        #endregion

        #region Public Properties

        #endregion

        #region  Private Methods 
        private void CreateDeck()
        {
            foreach (string suit in _Suits)
            {
                foreach (uint value in _Values)
                {
                    string cardname = suit + value.ToString() + ".gif";
                    Bitmap bmp = new Bitmap("images/" + cardname);

                    Card card = new Card();

                    card.pbCard.Image = bmp;
                    card.pbCard.Height = bmp.Height;
                    card.pbCard.Width = bmp.Width;
                    card.FrontImage = bmp;
                    card.Suit = suit;
                    card.Value = value;

                    bmp = new Bitmap("Images/b2fv.gif");
                    card.BackImage = bmp;

                    bmp = new Bitmap("Images/hold" + cardname);
                    card.HoldImage = bmp;
                    
                    _Cards.Add(card);

                }
            }
        }
        private void Shuffle()
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < _Cards.Count; i++)
                {
                    int position = _rnd.Next(0, 52);
                    Card temp = new Card();
                    temp = _Cards[i];
                    _Cards[i] = _Cards[position];
                    _Cards[position] = temp;
                }
            }
        }
        private void LoadShoe()
        {
            foreach (Card card in _Cards)
            {
                _Shoe.Enqueue(card);
            }
        }
        #endregion

        #region  Public Methods 
        public Card Deal()
        {
            Card card = _Shoe.Dequeue();
            return card;
            
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public Deck(Form f, Random r)
        {
            _rnd = r;
            _Form = f;
            _Shoe = new Queue<Card>();
            _Cards = new List<Card>();
            CreateDeck();
            Shuffle();
            LoadShoe();
            

        }
        #endregion

    }
}
