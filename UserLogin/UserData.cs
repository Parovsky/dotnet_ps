using System;
namespace UserLogin
{
    public static class UserData
    {
        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        private static User _testUser;

        private static void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User
                {
                    Username = "Ivan",
                    Password = "password",
                    FakNum = "123219015",
                    Role = 1
                };
            }
        }
    }
}
