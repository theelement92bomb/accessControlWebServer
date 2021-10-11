using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MyWebServer.Controllers
{
    [Route("UserAccess")]
    public class UserAccessController : Controller
    {
        private IConfiguration _configuration;

        public UserAccessController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("Users")]
        public IActionResult GetUsers()
        {
            List<User> userList = new List<User>();
            string connectionString = _configuration["ConnectionStrings:DefaultConnectionString"];

            SqlConnection conn = new SqlConnection(connectionString);

            string query = "select * from tblUsers";

            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = conn;

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new User();

                    user.UserId = (string)reader["UserId"];
                    user.LastName = (string)reader["LastName"];
                    user.FirstName = (string)reader["FirstName"];
                    user.RoleId = (decimal)reader["RoleId"];
                    user.Department = (string)reader["Department"];

                    userList.Add(user);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Ok(userList);
        }

        [HttpPost("AddUser")]
        public IActionResult AddNewUser([FromBody]User user)
        {
            string connectionString = _configuration["ConnectionStrings:DefaultConnectionString"];
            string query = "insert tblUsers (UserId, LastName, FirstName, RoleId, Department) values(@UserId, @LastName, @FirstName, @RoleId, @Department)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;

                conn.Open();

                SqlParameter param1 = new SqlParameter("@UserId", user.UserId);
                command.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@LastName", user.LastName);
                command.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter("@FirstName", user.FirstName);
                command.Parameters.Add(param3);
                SqlParameter param4 = new SqlParameter("@RoleId", user.RoleId);
                command.Parameters.Add(param4);
                SqlParameter param5 = new SqlParameter("@Department", user.Department);
                command.Parameters.Add(param5);

                int result = command.ExecuteNonQuery();
            }


            return Ok("OK");

        }

        [HttpPost("UpdateUser/{userId}")]
        public IActionResult UpdateUser([FromBody]User user, string userId)
        {
            string connectionString = _configuration["ConnectionStrings:DefaultConnectionString"];
            string query = "update tblUsers set RoleId = @RoleId, Department = @Department where UserId = @UserId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;

                conn.Open();

                SqlParameter param1 = new SqlParameter("@UserId", user.UserId);
                command.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@RoleId", user.RoleId);
                command.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter("@Department", user.Department);
                command.Parameters.Add(param3);

                int result = command.ExecuteNonQuery();
            }

            return Ok("OK");
        }

        [HttpDelete("DeleteUser/{userId}")]
        public IActionResult DeleteUser(string userId)
        {
            string connectionString = _configuration["ConnectionStrings:DefaultConnectionString"];
            string query = "delete from tblUsers where UserId = @UserId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;

                conn.Open();

                SqlParameter param1 = new SqlParameter("@UserId", userId);
                command.Parameters.Add(param1);

                int result = command.ExecuteNonQuery();
            }

            return Ok("Ok");
        }
    }

    public class User
    {
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal RoleId { get; set; }
        public string Department { get; set; }
    }
}
