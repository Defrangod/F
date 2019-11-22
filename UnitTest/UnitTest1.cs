using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using Practice;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthorizationAdminTest()
        {
            //Arrange
            string login = "12";
            string password = "1";
            string expectdRole = "Администратор";
            string actualRole = "Администратор";
            //Act
            DBConnection.Connect();
            DBConnection.Autorization(login, password);
            actualRole = DBConnection.Role;
            //Assert
            Assert.AreEqual(expectdRole, actualRole);
        }
    }
}
