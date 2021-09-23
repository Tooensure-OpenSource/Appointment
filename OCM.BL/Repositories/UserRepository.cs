using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class UserRepository
    {
        /// <summary>
        /// Saves the User data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined User

            return true;
        }

        /// <summary>
        /// Retrieves the User data
        /// </summary>
        /// <returns></returns>
        public User Retrieve(int userId)
        {
            // create instance of User class
            // pass in request ID
            var user = new User(userId);


            // Code that retrieves the defined User

            // Temporary hard-coded values to return
            // a populated customer
            if (userId == 1)
            {
                user.Email = "tooensurellc@gmail.com";
                user.Password = "1234";
            }

            return user;
        }

        /// <summary>
        /// Retrieves all Users
        /// </summary>
        /// <returns></returns>
        public IList<User> Retrieve()
        {
            // Code that retrieves the defined User
            return new List<User>();
        }
    }
}
