using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "Qwerty_2";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_8Symbols_Returnsfalse()
        {
            string password = "Qwerty";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);

        }

        [TestMethod()]
        public void Check_20Symbols_Returnsfalse()
        {
            string password = "QqqqWeeeRrrrTtttYyyy2";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_Numbers_ReturnsTrue()
        {
            string password = "Qwerty_2";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_Numbers_Returnsfalse()
        {
            string password = "Qwer_ty";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_SpecialCharacters_ReturnsTrue()
        {
            string password = "QWERTY_2";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_SpecialCharacters_Returnsfalse()
        {
            string password = "QWERTY";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_UppercaseLetters_ReturnsTrue()
        {
            string password = "QQwweerrttyy_22";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_UppercaseLetters_Returnsfalse()
        {
            string password = "QQWWEERRTTYY";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_LowercaseLetters_ReturnsTrue()
        {
            string password = "Qwerty_2222";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Check_LowercaseLetters_Returnsfalse()
        {
            string password = "Qwerty2222";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);

        }
    }

}
