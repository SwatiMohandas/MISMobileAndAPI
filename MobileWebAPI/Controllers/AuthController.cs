using BCrypt.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MobileWebAPI.DAL;
using DTO.Login;
using System.Data;
using System.Data.SqlClient;
using System.Web.Helpers;
using BCr = BCrypt.Net;
using MobileWebAPI.Models;

namespace MobileWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;
        SqlConnection myConnection1 = null;
        SqlConnection myConnection2 = null;
        Users logins = new Users();

        private readonly JwtSettings jwtSettings;

        public AuthController(JwtSettings jwtSettings)
        {
            this.jwtSettings = jwtSettings;

        }

        [HttpPost]
        public IActionResult Login_Approval(UserLogins userLogins)
        {
            var Token = new UserTokens();
            Users user = null;
            try
            {
                SqlDataReader reader = null;
                myConnection = db.GetConnectionMIS();

                SqlCommand sqlCmd = new SqlCommand("SP_GET_USER_LOGIN_DETAILS", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserName", userLogins.UserName);
                sqlCmd.Parameters.AddWithValue("@Password", userLogins.Password);
                sqlCmd.Parameters.AddWithValue("@IMEI", userLogins.IMEI);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Users();
                    user.Id = reader["Id"].ToString();
                    user.UserName = reader["UserName"].ToString();
                    user.PasswordHash = reader["PasswordHash"].ToString();
                    user.DeviceIME = reader["DeviceIME"].ToString();
                    user.Approved = reader["Approved"].ToString();
                    user.EmplyeeTypeId = reader["EmplyeeTypeId"].ToString();
                    user.RoleId = reader["RoleId"].ToString();
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.Email = reader["Email"].ToString();
                }
                if (reader.HasRows == true)
                {
                    bool k = Crypto.VerifyHashedPassword(user.PasswordHash, userLogins.Password);
                    if (k)
                    {
                        Token = JwtHelpers.JwtHelpers.GenTokenkey(new UserTokens()
                        {
                            EmailId = user.Email,
                            GuidId = Guid.NewGuid(),
                            UserName = user.UserName,
                            Id = Guid.NewGuid()//user.Id,

                        }, jwtSettings);
                        user.Token = Token.Token.ToString();
                        if (user.Approved == "1")
                        {
                            if (user.EmplyeeTypeId != "4")
                            {
                                if (user.RoleId == "6cbcb766-ef97-4e4c-9a82-1b8c3b7a3ecb")
                                {
                                    user.EmplyeeTypeId = "10";
                                }
                                if (user.RoleId == "0887966d-964d-4478-884a-9b0df7269352")
                                {
                                    user.EmplyeeTypeId = "11";
                                }
                                if (user.RoleId == "046bd870-ad9d-49e7-8896-16fe33750069")//factory a/c
                                {

                                    user.EmplyeeTypeId = "13";
                                }
                                if (user.RoleId == "1c31c65a-9b93-4f53-be58-6de04aaf8928")//factory hr
                                {
                                    user.EmplyeeTypeId = "12";
                                }
                                if (user.RoleId == "2fb2f2d0-73d9-48ec-a808-1aed21fac565")//factory employee
                                {
                                    user.EmplyeeTypeId = "15";
                                }
                                if (user.RoleId == "700dfde7-f524-4d6a-99da-c674d6f61d98")//factory suprivisor
                                {
                                    user.EmplyeeTypeId = "16";
                                }

                                if (user.RoleId == "f7a491dc-c231-431f-b5fd-19f503ee840f")
                                {
                                    user.EmplyeeTypeId = "14";
                                }
                                if (user.RoleId == "f9730cdc-ecc3-4ff9-8667-2ee52ad7dad9")
                                {
                                    user.EmplyeeTypeId = "18";
                                }


                                if (user.RoleId == "a0c4e683-c1d0-4ba6-bd51-4a875e7d7c4a" || user.RoleId == "79aa4621-8abb-4784-9a4b-face61e5aa3a")
                                {
                                    user.EmplyeeTypeId = "17";
                                }
                            }
                            else if (user.EmplyeeTypeId == "4")
                            {
                                myConnection1 = db.GetConnection();

                                SqlCommand cmd7 = new SqlCommand("SP_GET_MIS_GET_DIVISION_BYUSERID", myConnection1);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                cmd7.Parameters.AddWithValue("@UserID", user.Id);

                                myConnection1.Open();
                                reader = cmd7.ExecuteReader();
                                myConnection1.Close();

                                while (reader.Read())
                                {
                                    user.Division_ID = reader["Division_ID"].ToString();
                                }
                                if (user.Division_ID == "33")
                                {
                                    user.Division_ID = "23";
                                }
                            }
                            else
                            {
                                user.Division_ID = "0";
                            }

                        }
                        else
                        {
                            user.Id = "0";
                            return BadRequest($"User is not Approved");
                        }


                    }
                    else
                    {
                        return BadRequest($"Please enter valid User Details");
                    }

                }
                else
                {
                    try
                    {
                        myConnection2 = db.GetConnectionMIS();
                        SqlCommand sqlCmd1 = new("INSERT INTO DeviceDetails(DeviceIME,UserID,UserName,LoginDate,Approved,IsActive) Values('" + userLogins.IMEI + "',(select top 1 Id from AspNetUsers where AspNetUsers.UserName = '" + userLogins.UserName + "'),'" + userLogins.UserName + "','" + System.DateTime.Now + "','" + 0 + "','" + 1 + "')", myConnection2);
                        sqlCmd1.CommandType = CommandType.Text;
                        myConnection2.Open();
                        int rowInserted1 = sqlCmd1.ExecuteNonQuery();
                        myConnection2.Close();
                        //user.Id = "0";
                        return BadRequest($"User waiting for Approval");
                    }
                    catch (Exception ex) { }
                }
                myConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(user);
        }
    }
}
