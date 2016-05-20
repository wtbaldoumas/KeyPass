using System.Collections.Generic;
using KeyPassInfoObjects;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KeyPassBusiness
{
    public static class KeyPassManager
    {
        private static string _fileName = "KeyPass";
        private static List<Group> _groups = new List<Group>();
        private static List<Group> _loadGroups = new List<Group>();

        public static void AddGroup(Group group)
        {
            _groups.Add(group);
        }

        public static void RemoveGroup(Group group)
        {
            _groups.Remove(group);
        }
 
        public static void AddKeyToGroup(Group group, Key key)
        {
            group.Keys.Add(key);
        }

        public static void RemoveKeyFromGroup(Group group, Key key)
        {
            group.Keys.Remove(key);
        }

        public static List<Group> GetAllGroups()
        {
            return _groups;
        }

        public static List<Group> Groups
        {
            get { return _groups; }
            set { _groups = value; }
        }

        public static List<Group> LoadGroups
        {
            get { return _loadGroups; }
            set { _loadGroups = value; }
        }

        public static string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public static void CryptoSave()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                // serialize the user's information to the MemoryStream for encryption
                binaryFormatter.Serialize(memoryStream, _groups);

                byte[] buffer = memoryStream.GetBuffer();
                byte[] cipherBuffer = Cryptographer.Encrypt(buffer, Authenticator.PasswordBytes);

                using (FileStream fileStream = File.OpenWrite(FileName))
                {
                    fileStream.Write(cipherBuffer, 0, cipherBuffer.Length);
                }
            }
        }

        public static bool CryptoOpen(string fileName)
        {
            _loadGroups = new List<Group>();
            byte [] cipher = File.ReadAllBytes(fileName);

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(Cryptographer.Decrypt(cipher, Authenticator.PasswordBytes)))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    _loadGroups = (List<Group>)binaryFormatter.Deserialize(memoryStream);
                    return true;
                } // if the password is wrong an incorrect key will be generated and the following exception will be thrown
            } catch (System.Security.Cryptography.CryptographicException) { return false; }
        }

        public static void OnNewClick()
        {
            _groups.Clear();
            _fileName = "KeyPass";
        }
    }
}
