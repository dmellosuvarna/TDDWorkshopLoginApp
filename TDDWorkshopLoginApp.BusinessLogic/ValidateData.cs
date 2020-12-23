using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TDDWorkshopLoginApp.BusinessLogic
{
    public class ValidateData
    {
        public bool ValidateUserName(string username)
        {
            if (username != null && username != "" && (username.Length > 1 && username.Length <= 11) && Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool ValidatePassword(string password)
        {
            if (password != "" && Regex.IsMatch(password, @"[0-9]+") && Regex.IsMatch(password, "^(?=.*[A-Za-z]{2})(?=.*\\d)[A-Za-z\\d]{6,}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

