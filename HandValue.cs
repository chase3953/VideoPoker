using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPoker
{
    public class HandValue
    {
        #region Private Members
        private string _Description = string.Empty;
        private Values _Multiplier = 0; 
        #endregion

        #region Public Properties
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        public Values Multiplier
        {
            get
            {
                return _Multiplier;
            }
            set
            {
                _Multiplier = value;
            }
        }
        #endregion

        #region  Private Methods 

        #endregion

        #region  Public Methods 

        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 

        #endregion
    }
    public enum Values
    {
        HighCard = 0,
        Pair = 1,
        TwoPair = 2,
        ThreeofaKind = 3,
        Straight = 4,
        Flush = 5,
        FullHouse = 6,
        FourofaKind = 7,
        StraightFlush = 8,
        RoyalFlush = 9
    }
}
