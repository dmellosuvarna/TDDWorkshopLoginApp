using NUnit.Framework;

namespace TDDWorkshopLoginApp.BusinessLogic.Tests
{
    
    public class CreateAccountTest
    {
        CustomMessage customMsg=new CustomMessage();
        [SetUp]
        public void Setup()
        {
            
        }

         [Test]
        public void ShouldReturnSuccessonCreateAccount()
        {
            CreateAccount user=new CreateAccount();
            string result= user.CreateUser("suvarna","password123");
            Assert.AreEqual(customMsg.DisplayMessages("UserSuccess"),result);            
        }

        [Test]
        public void ShouldReturnFailIfUserIsNullonCreateAccount()
        {
            CreateAccount user=new CreateAccount();
            string result= user.CreateUser(null,"password");
            //Assert.AreEqual("User Creation Failed -Null Username",result);
            Assert.AreEqual(customMsg.DisplayMessages("UserFailure"), result);
           
        }

        [Test]
        public void ShouldReturnFailedonCreateAccount()
        {
            CreateAccount user=new CreateAccount();
            string result= user.CreateUser("suvarna","");
            Assert.AreEqual(customMsg.DisplayMessages("UserFailure"),result);
            
        }

       


    }
}