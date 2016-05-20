using System;

namespace KeyPassBusiness
{
    public static class TestInputGenerator
    {
        public static string GetTestGroupTitle()
        {
            Random rand = new Random();
            string testGroupName = "Group-" + rand.Next(1, 1000).ToString();
            return testGroupName;
        }

        public static void GetTestKeyFields(out string title, out string username, out string password, out string url, out string notes)
        {
            Random rand = new Random();
            int testNumber = rand.Next(1, 1000);

            title = "Title-" + testNumber.ToString();
            username = "Username-" + testNumber.ToString();
            password = "Password-" + testNumber.ToString();
            url = "www.bu.edu/" + testNumber.ToString();
            notes = "Notes- " + testNumber.ToString();
        }
    }
}
