using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Utility
    {

        public bool ValidateEmail(string mailId)
        {
            string email = mailId;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (string.IsNullOrWhiteSpace(mailId))
            {
                return false;
            }
            if (match.Success)
                return true;
            else
                return false;
        }

        public bool ValidatePhoneNumber(string phone)
        {
            string p = phone;
            Regex regex = new Regex("^(\\+91[\\-\\s]?)?[0]?(91)?[789]\\d{9}$");
            Match match = regex.Match(p);
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }
            if (match.Success)
                return true;
            else
                return false;
        }


    }
}
