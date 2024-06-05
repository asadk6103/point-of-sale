using posapp.Database.ContextProvider;
using posapp.Database.Models;
using posapp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Controllers
{
    public class UserController
    {

        public static (int code, string message, User user) GetLoggedIn(string username, string password)
        {
            try
            {
                User cusr = null;
                password = PasswordHashing.EncodePassword(password);
                using (POSContext context = new POSContext())
                {
                    if (username.Contains("@")) {
                        cusr = context.User.Where(u => u.Email == username && u.Password == password ).FirstOrDefault();
                    }
                    else
                    {
                        cusr = context.User.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();
                    }

                    if (cusr != null) { 
                        return(200, "Found User", cusr);
                    }
                    else
                    {
                        return (404, "User Not Found", null);
                    }
                }
            }
            catch (Exception ex)
            {
                return (400, $"Error {ex.Message}", null);
            }

        }
    }
}
