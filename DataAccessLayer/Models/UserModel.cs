using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace DataAccessLayer.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "User Name Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Address Required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Required")]
        public string ConfirmPwd { get; set; }
    }
}