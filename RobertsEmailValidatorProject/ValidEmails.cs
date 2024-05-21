using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobertsEmailValidatorProject
{
    public class ValidEmails
    {   
        public static bool NotNullEmail(string email)
        {
            string _email = email;
            bool isValid = false;
         
            if (_email != null) { isValid = true; }
           
            return isValid;

        }
        //public static bool NotNullEmail(string email)
        //{
        //    string _email = email;
        //    bool isValid = false;

        //    if (_email != null) { isValid = true; }

        //    return isValid;

        //}

    }
}
