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
            else
            {
                Console.WriteLine("Email is Required");
            }

            return isValid;

        }
        public static bool ContainsAtSymbol(string email)
        {
            string _email = email;
            char[] chars = _email.ToCharArray();
            int at = email.IndexOf('@');
            string afterAt = email.Substring(at+2);
            char dot = '.';
            bool isValid = false;

            if (at > -1  || char.IsLetterOrDigit(chars[at - 1]) || char.IsLetterOrDigit(chars[at + 1]) || afterAt.Contains(dot))
                {  isValid = true; }
            else 
            { 
                isValid = false;
                Console.WriteLine("Email must be in the form username@domain.domainextension"); 

            }
            return isValid;

        }


      

    }
}
