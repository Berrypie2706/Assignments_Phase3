using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [TestFixture]
    public class UserAuthenticatorTest
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void SetUp()
        {
            userAuthenticator = new UserAuthenticator();
        }
        [Test]
        public void TestUserRegistration()
        {
            userAuthenticator.UserRegistration("Kalpana", "Kp@123");
            Assert.IsTrue(userAuthenticator.UserLogin("Kalpana", "Kp@123"));
        }
        [Test]
        public void TestUserLogin()
        {
            userAuthenticator.UserRegistration("Kalpana", "Kp@123");
            Assert.IsTrue(userAuthenticator.UserLogin("Kalpana", "Kp@123"));
            Assert.IsFalse(userAuthenticator.UserLogin("Kalpan", "k@123"));
            Assert.IsFalse(userAuthenticator.UserLogin("Kapana", "kp123"));
        }
        [Test]
        public void TestPasswordReset()
        {
            userAuthenticator.UserRegistration("Kalpana", "Kp@123");
            userAuthenticator.PasswordReset("Kalpana", "kp2@123");
            Assert.IsTrue(userAuthenticator.UserLogin("Kalpana", "kp2@123"));
        }
    }
}
