using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static bool ContainsAtSymbol(string email)
        {
            string _email = email;
            char[] chars = _email.ToCharArray();
            bool containsAt = email.Contains('@');
            char dot = '.';
            bool isValid = false;

            if (containsAt == true) 

                {
                    int at = email.IndexOf('@');
                    string afterAt = email.Substring(at + 2);

                        if ( char.IsLetterOrDigit(chars[at - 1]) || char.IsLetterOrDigit(chars[at + 1]) || afterAt.Contains(dot))
                        { isValid = true; }
                }
            
           
            return isValid;
        }
         //|| char.IsLetterOrDigit(chars[at - 1]) || char.IsLetterOrDigit(chars[at + 1]) || afterAt.Contains(dot)




    }
}
