using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.Username = "Ivan";
            user.Password = "password";
            user.FakNum = "123219015";
            user.Role = 1;

            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("User password: " + user.Password);
            Console.WriteLine("User faculty number: : " + user.FakNum);
            Console.WriteLine("User Role: : " + user.Role);
        }
    }
}
