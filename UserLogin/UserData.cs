using System;
namespace UserLogin
{
    public static class UserData
    {
        public static User TestUser;

        private static void ResetTestUserData()
        {
            if (TestUser == null)
            {
                TestUser = new User
                {
                    Username = "Ivan",
                    Password = "password",
                    FakNum = "123219015",
                    Role = 1
                };
            }
        }

        public static User GetUser()
        {
            ResetTestUserData();
            return TestUser;
        }
    }
}
