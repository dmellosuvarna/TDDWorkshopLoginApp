using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TDDWorkshopLoginApp.BusinessLogic
{
   public class CreateAccount
    {
        // Create Dictionary.
        public Dictionary<string, string> Dict_LoginData = new Dictionary<string, string>();
        CustomMessage customMessage=new CustomMessage();
     
        public string CreateUser(string username,string password)
        {
            string result="";
            if(password !="" && ValidateUserName(username) && ValidatePassword(password))
            {
                Dict_LoginData.Add(username,password);
               #region toberemovedValidate data in Dictionary
              /*  foreach(KeyValuePair<string, string> element in Dict_LoginData) 
                { 
                    Console.WriteLine("CreateUserKey:- {0} and CreateUserValue:- {1}",  
                                    element.Key, element.Value); 
                } */
                #endregion
               // result=SuccessMessage(); 
                result=customMessage.DisplayMessages("UserSuccess");              
             
            }
            else
            {
               // result=FailureMessage();
                result=customMessage.DisplayMessages("UserFailure");
            }
            return result;
        }

        public bool ValidateUserName(string username)
        {                      
           if(username !=null && username !="" && (username.Length >1 && username.Length <=11) && Regex.IsMatch(username, @"^[a-zA-Z]+$"))
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
            if( Regex.IsMatch(password, @"[0-9]+") && Regex.IsMatch(password, "^(?=.*[A-Za-z]{2})(?=.*\\d)[A-Za-z\\d]{6,}$"))
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
