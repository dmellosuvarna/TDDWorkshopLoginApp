namespace TDDWorkshopLoginApp.BusinessLogic
{
    using System;
    using System.Collections.Generic;

    public class CustomMessage
    {    
        public string DisplayMessages(string type)
        {
            string result="";
            switch(type)
            {
                case "UserSuccess":
                        result="User Created successfully";
                        break;
                case "UserFailure":
                        result="User Creation Failed";
                        break;
                case "LoginSuccess":  
                        result="User Loggedin Successfully";
                        break;
                case "LoginFailure":  
                        result="User Loggedin Failed";
                        break;
                case "ValidUser":  
                        result="Valid Username";
                        break;
                case "InValidUser":  
                        result="InValid Username";
                        break;
                case "ValidPassword":  
                        result="Valid Password";
                        break;
                case "InValidPassword":  
                        result="InValid Password";
                        break;

            }
            return result;    
        }
    }
}

