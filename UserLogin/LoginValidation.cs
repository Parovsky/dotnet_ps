using System;
namespace UserLogin
{
    public class LoginValidation
    {
        public static UserRoles currentUserRole;

        public LoginValidation()
        {
        }

        public bool ValidateUserInput()
        {
            currentUserRole = UserRoles.ADMIN;
            return true;
        }
    }
}
