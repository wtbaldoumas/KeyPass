using System;

namespace KeyPassInfoObjects
{
    [Serializable]
    public class Key
    {
        private string _title = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _url = string.Empty;
        private string _notes = string.Empty;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
    }
}
