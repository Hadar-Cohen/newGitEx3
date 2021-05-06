using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ex2.Models;
using Ex2.Models.DAL;

namespace Ex2.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        public List<User> Get()
        {
            User us = new User();
            List<User> userlist = us.Get();
            return userlist;
        }
        public HttpResponseMessage Get(string email, string password)
        {
            User us = new User();
            User u= us.checkLogin(email, password);

            if (u!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, u);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "user not found");
            }
        }
        // GET api/<controller>/5
        //public User Get(string email,string password) //check the login details
        //{ 
        //    User us = new User();
        //    return us.checkLogin(email, password);
        //}

        // POST api/<controller>
        public int Post([FromBody] User user)
        {
            if (isValidEmail(user.Email))
                return 0; //email exists already
            else
            {
                return user.Insert(); //return 1
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        private bool isValidEmail(string userEmail)
        {
            User us = new User();
            return us.checkEmail(userEmail);
        }
    }
}