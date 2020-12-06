using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDay19
{
    public abstract class User
    {

        public  void Login(string username, string password)
        {
            //login code
        }
        public void logout()
        {

        }
        public abstract void ChangePassword(string newPassword);
    }
}
