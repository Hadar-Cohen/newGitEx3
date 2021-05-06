using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ex2.Models;

namespace Ex2.Models.DAL
{
    public class UserDataServices
    {
        static List<User> userList = new List<User>();
    //
        public int Insert(User u)
        {
            userList.Add(u);
            return 1;
        }
        public List<User> Get()
        {
            return userList;
        }

        public User checkLogIn(string email, string pass)
        {
            User user = new User();
            foreach (User u in userList)
            {
                if (u.Email.Equals(email) && u.Password.Equals(pass))
                    return u;
            }
            return null;
        }
        public bool checkEmail(string userMail)
        { 
            foreach (User u in userList)
            {
                if (u.Email.Equals(userMail))
                    return true;
            }
            return false;
        }
    }
}