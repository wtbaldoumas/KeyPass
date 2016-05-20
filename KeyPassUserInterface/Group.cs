/*
    William Baldoumas
    CS503 - Project 3
    Due 03/03/2016
*/

using System;
using System.Collections.Generic;

namespace KeyPassInfoObjects
{
    [Serializable]
    public class Group
    {
        #region private members;
        private string _name = string.Empty;
        private List<Key> _keys = new List<Key>();
        #endregion;

        #region interface;
        public string Name
        {
           get { return _name; }
           set { _name = value; }
        }

        public List<Key> Keys
        {
            get { return _keys; }
            set { _keys = value; }
        }
        #endregion;

        #region misc
        public override string ToString() // for use in KeyListControl combo box
        {
            return _name;
        }
        #endregion;
    }
}
