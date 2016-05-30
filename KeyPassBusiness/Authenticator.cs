namespace KeyPassBusiness
{
    public static class Authenticator
    {
        private static byte[] _cryptoBytes = null;

        public static byte[] CryptoBytes
        {
            get { return _cryptoBytes; }
            set { _cryptoBytes = value; }
        }
    }
}
