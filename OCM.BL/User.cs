using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class User : EntityBase
    {
        /// <summary>
        ///  Constructor instance
        /// </summary>
        public User() { }
        public User(int userId) { Userid = userId; }

        // Uniqe ID
        public int Userid { get; private set; }
        public int UserType { get; set; }
        // Auth1
        public string Email { get; set; }
        // Auth2 ShaHash(256)
        public string Password { get; set; }

        /// <summary>
        /// Used for testing application (UserTest.cs)
        /// </summary>
        public string Auth
        {
            get 
            {
                // Examination
                // Data1 Length
                bool email = !string.IsNullOrWhiteSpace(Email) && Email.ToCharArray().Length <= 50;
                bool password = !string.IsNullOrWhiteSpace(Password) && Password.ToCharArray().Length <= 10;
                // Output actions
                string submit = $"Email = {email}, Password = {password}";
                // Auth Reponse (Check Data1 Data2) { } <= Modthod Notice
                string Auth = email && password ? $"Response = Success, " : "Response = Error, ";
                // Add print submit
                Auth += submit;
                return Auth;
            }
        }



        /// <summary>
        /// Validates the User data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Password)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

    }
}
