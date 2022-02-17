using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = UserData.GetUser();

            if (new LoginValidation().ValidateUserInput())
            {
                Console.WriteLine("Username: " + user.Username);
                Console.WriteLine("User password: " + user.Password);
                Console.WriteLine("User faculty number: : " + user.FakNum);
                Console.WriteLine("User Role: : " + user.Role);
            }
        }
    }
}
