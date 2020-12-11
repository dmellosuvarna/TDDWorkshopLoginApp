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

        [Test]
        public void ShouldreturnTrueOnValidUserifNotNull()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName("suvarna");         
            Assert.IsTrue(result,"Login failed.InValid Username is NULL");
                  
        }

         [Test]
        public void ShouldreturnFalseOnInValidUserIfNull()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName(null);          
            Assert.IsFalse(result,"Valid Username");      
            
        }

       [Test]
        public void ShouldreturnTrueOnValidUserAlphabetsOnly()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName("suvarna");         
            Assert.IsTrue(result,"Login failed. Invalid username - contains nonalphbets");
                  
        }

         [Test]
        public void ShouldreturnFalseOnInValidUserNonAlphabet()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName("suvarna1234");          
            Assert.IsFalse(result,"Valid Username");      
            
        }

        [Test]
        public void ShouldreturnTrueOnValidUserLength()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName("suvarnadme");         
            Assert.IsTrue(result,"Login failed. Invalid username Length");
                  
        }

        [Test]
        public void ShouldreturnFalseOnInValidUserLength()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidateUserName("suvarnadmello");         
            Assert.IsFalse(result,"Valid Username Length");
                  
        }

      /*  [Test]
       public void ShouldreturnTrueOnValidPassword()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidatePassword("12345678");         
            Assert.IsTrue(result,"“Login failed. Invalid password - contains numbers");
                  
        }*/
        [Test]
        public void ShouldreturnFalseOnInValidPassword()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidatePassword("abcdef");          
            Assert.IsFalse(result,"Valid Password");      
            
        }
        [Test]
        public void ShouldreturnTrueIfAtleastTwoAlphabetPresentinPassword()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidatePassword("pass123");         
            Assert.IsTrue(result,"InValid Password");
                  
        }

        [Test]
        public void ShouldreturnFalseIfAtleastTwoIntegerNotPresentinPassword()
        {
            CreateAccount user=new CreateAccount();
            var result =user.ValidatePassword("password");         
            Assert.IsFalse(result,"InValid Password");
                  
        }    
      


    }
}