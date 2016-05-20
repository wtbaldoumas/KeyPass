namespace KeyPassBusiness
{
    public static class Authenticator
    {
        private static byte[] _passwordBytes = null;

        public static byte[] PasswordBytes
        {
            get { return _passwordBytes; }
            set { _passwordBytes = value; }
        }
    }
}
