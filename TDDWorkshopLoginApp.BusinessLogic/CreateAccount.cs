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
        ValidateData validateData=new ValidateData();
     
        public string CreateUser(string username,string password)
        {
            string result="";
            if(validateData.ValidateUserName(username) && validateData.ValidatePassword(password))
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


    }

}
