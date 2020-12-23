using NUnit.Framework;

namespace TDDWorkshopLoginApp.BusinessLogic.Tests
{
    public class ValidateDataTest
    {
        ValidateData user;
        [OneTimeSetUp]
        public void setup()
        {
            user = new ValidateData();
        }

        [Test]
        public void ShouldreturnTrueOnValidUserifNotNull()
        {
            
            var result = user.ValidateUserName("suvarna");
            Assert.IsTrue(result, "Login failed.InValid Username is NULL");

        }

        [Test]
        public void ShouldreturnFalseOnInValidUserIfNull()
        {
            
            var result = user.ValidateUserName(null);
            Assert.IsFalse(result, "Valid Username");

        }

        [Test]
        public void ShouldreturnTrueOnValidUserAlphabetsOnly()
        {
            
            var result = user.ValidateUserName("suvarna");
            Assert.IsTrue(result, "Login failed. Invalid username - contains nonalphbets");

        }

        [Test]
        public void ShouldreturnFalseOnInValidUserNonAlphabet()
        {
            
            var result = user.ValidateUserName("suvarna1234");
            Assert.IsFalse(result, "Valid Username");

        }

        [Test]
        public void ShouldreturnTrueOnValidUserLength()
        {
            
            var result = user.ValidateUserName("suvarnadme");
            Assert.IsTrue(result, "Login failed. Invalid username Length");

        }

        [Test]
        public void ShouldreturnFalseOnInValidUserLength()
        {
            
            var result = user.ValidateUserName("suvarnadmello");
            Assert.IsFalse(result, "Valid Username Length");

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
            
            var result = user.ValidatePassword("abcdef");
            Assert.IsFalse(result, "Valid Password");

        }
        [Test]
        public void ShouldreturnTrueIfAtleastTwoAlphabetPresentinPassword()
        {
            
            var result = user.ValidatePassword("pass123");
            Assert.IsTrue(result, "InValid Password");

        }

        [Test]
        public void ShouldreturnFalseIfAtleastTwoIntegerNotPresentinPassword()
        {
            
            var result = user.ValidatePassword("password");
            Assert.IsFalse(result, "InValid Password");

        }
        [OneTimeTearDown]
        public void Teardown()
        {
            user = null;
        }

    }
}
