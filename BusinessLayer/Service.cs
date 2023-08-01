using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using DataAccessLayer.Models; 

namespace BusinessLayer
{
    public class Service
    {
        private Access access = new Access();

        public void AddUser(UserModel user) {
            access.AddUser(user); 
        }

        public List<UserModel> GetAllUsers() {
            return access.GetAllUsers(); 
        }
    }
}