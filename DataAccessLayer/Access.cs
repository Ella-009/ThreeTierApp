using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DataAccessLayer.Models;
using System.Configuration;

namespace DataAccessLayer
{
    public class Access
    {
        private string connectionString = "data source=LAPTOP-J9KULEIK\\MYSERVER;initial catalog=UserDB;persist security info=True;user id=sa;password=123456;"; 

        public void AddUser(UserModel user) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string addSql = "Insert into UserTable (UserName, EmailAddress, Password) Values (@UserName, @EmailAddress, @Password)";

                using (SqlCommand command = new SqlCommand(addSql, connection)) {
                    //command.Parameters.Add(new SqlParameter("@UserId", 1)); 
                    command.Parameters.Add(new SqlParameter("@UserName", user.UserName));
                    command.Parameters.Add(new SqlParameter("@EmailAddress", user.EmailAddress));
                    command.Parameters.Add(new SqlParameter("@Password", user.Password));

                    command.ExecuteNonQuery(); 
                }
            }
        }

        public List<UserModel> GetAllUsers() {
            List<UserModel> result = new List<UserModel>(); 
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string addSql = "Select * from UserTable";

                using (SqlCommand command = new SqlCommand(addSql, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {

                        UserModel user = new UserModel(); 
                        user.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                        user.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                        user.EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")); 

                        result.Add(user); 
                    }
                    reader.Close(); 
                } 
                
            } 
            return result;
        }
    }
}