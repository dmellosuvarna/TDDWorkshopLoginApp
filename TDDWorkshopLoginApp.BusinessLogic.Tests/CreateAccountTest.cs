using NUnit.Framework;

namespace TDDWorkshopLoginApp.BusinessLogic.Tests
{
    
    public class CreateAccountTest
    {
        CreateAccount user;
        CustomMessage customMsg;
        
        [SetUp]
        public void Setup()
        {
            user = new CreateAccount();
            customMsg = new CustomMessage();
        }

         [Test]
        public void ShouldReturnSuccessonCreateAccount()
        {
           
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

        [OneTimeTearDown]
        public void TearDown()
        {
            user = null;
            customMsg = null;
        }

       


    }
}