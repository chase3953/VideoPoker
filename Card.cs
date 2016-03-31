using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    public class Card : IDisposable
    {
        #region Private Members
        private string _Suit = string.Empty;
        private uint _Value = 0;
        private Image _FrontImage = null;
        private Image _BackImage = null;
        private Image _HoldImage = null;
        private PictureBox _Card = null;
        private bool _IsHeld = false;
        private bool _IsFront = true;
        private Form _form = null;

        #endregion

        #region Public Properties
        public bool Holdable
        {
            set
            {
                if (value == true)
                {
                    _Card.MouseClick += _Card_MouseClick;
                }
                else
                {
                    _Card.MouseClick -= _Card_MouseClick;
                }
            }
        }
        public bool Bouncable
        {
            set
            {
                if (value == true)
                {
                    _Card.MouseEnter += _Card_MouseEnter;
                    _Card.MouseLeave += _Card_MouseLeave;                 
                }
                else
                {
                    _Card.MouseEnter -= _Card_MouseEnter;
                    _Card.MouseLeave -= _Card_MouseLeave;
                }
            }
        }
        public string Suit
        {
            get
            {
                return _Suit;
            }
            set
            {
            }
        }
        public uint Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = Value;
            }
        }
        public Image FrontImage
        {
            get
            {
                return _FrontImage;
            }
            set
            {
                _FrontImage = value;
            }
        }
        public Image BackImage
        {
            get
            {
                return _BackImage;
            }
            set
            {
                _BackImage = value;
            }
        }
        public Image HoldImage
        {
            get
            {
                return _HoldImage;
            }
            set
            {
                _HoldImage = value;
            }
        }
        public bool IsHeld
        {
            get
            {
                return _IsHeld;
            }
            set
            {
                _IsHeld = value;
            }
        }
        public PictureBox pbCard
        {
            get
            {
                return _Card;
            }
        }

        #endregion

        #region  Private Methods 
        
        #endregion

        #region  Public Methods 
        public void Flip()
        {
            _Card.Image = _FrontImage;           
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 
        private void _Card_MouseClick(object sender, MouseEventArgs e)
        {
            _IsHeld = !_IsHeld;
            if (_IsHeld == true)
            {
                _Card.Image = _HoldImage;
            }
            else
            {
                _Card.Image = _FrontImage;
            }
        }

        private void _Card_MouseLeave(object sender, EventArgs e)
        {
            Point location = _Card.Location;
            location.Y += 2;
            _Card.Location = location;
        }

        private void _Card_MouseEnter(object sender, EventArgs e)
        {
            Point location = _Card.Location;
            location.Y -= 2;
            _Card.Location = location;
        }
        #endregion

        #region Construction 
        public Card(Form form)
        {
            //LOAD THE IMAGE OF 1 CARD
            _form = form;
            _Card = new PictureBox();                       
        }

        

        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _form.Controls.Remove(_Card);
                }
                _FrontImage = null;
                _BackImage = null;
                _HoldImage = null;
                _Card = null;
                _form = null;

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Card() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
