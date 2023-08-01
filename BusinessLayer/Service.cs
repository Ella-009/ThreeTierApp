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
        private UserDBEntities userDBEntities;

        public Service() {
            userDBEntities = new UserDBEntities(); 
        }

        public void AddUser(UserModel userModel) {
            User user = new User()
            {
                UserName = userModel.UserName,
                EmailAddress = userModel.EmailAddress,
                Password = userModel.Password,
            };
            userDBEntities.Users.Add(user);
            userDBEntities.SaveChanges(); 
        }

        //public List<UserModel> GetAllUsers() {
            //return access.GetAllUsers(); 
        //}
    }
}