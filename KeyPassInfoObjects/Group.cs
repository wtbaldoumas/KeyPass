using System;
using System.Collections.Generic;

namespace KeyPassInfoObjects
{
    [Serializable]
    public class Group
    {
        private string _name = string.Empty;
        private List<Key> _keys = new List<Key>();

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

        public override string ToString() // for use in KeyListControl combo box
        {
            return _name;
        }
    }
}
