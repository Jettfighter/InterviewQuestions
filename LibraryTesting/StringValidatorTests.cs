using System;
using InterviewQuestionsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTesting
{
    [TestClass]
    public class StringValidatorTests
    {
        /*
            Test string - Expected result
            
            {} - True
            
            }{ - False (closed bracket can't proceed all open brackets.)
            
            {{} - False (one bracket pair was not closed)
            
            "" - True. (no brackets in the string will return True)
         */

        [TestMethod]
        public void StringWithMatchingBracketsIsTrue()
        {
            //Arrange
            string validString = "{}";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(validString);

            //Assert

            Assert.IsTrue(isValid, "A string that is valid is returning false!!!");
        }

        [TestMethod]
        public void StringWithMismatchingBracketsIsFalse()
        {
            //Arrange
            string invalidString = "}{";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(invalidString);

            //Assert

            Assert.IsFalse(isValid, "A string that is invalid is returning true!!!");
        }

        [TestMethod]
        public void StringWithUnclosedBracketPairIsFalse()
        {
            //Arrange
            string invalidString = "{{}";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(invalidString);

            //Assert

            Assert.IsFalse(isValid, "A string that has too many open brackets is returning true!!!");
        }

        [TestMethod]
        public void StringWithTooManyClosedBracketsIsFalse()
        {
            //Arrange
            string invalidString = "{}}";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(invalidString);

            //Assert

            Assert.IsFalse(isValid, "A string that has too many close brackets is returning true!!!");
        }

        [TestMethod]
        public void StringWithNoBracketsIsTrue()
        {
            //Arrange
            string validString = "\"\"";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(validString);

            //Assert

            Assert.IsTrue(isValid, "A string that has no brackets is returning false!!!");
        }

        //test to make sure special characters don't interfere with a valid string
        [TestMethod]
        public void StringWithSpecialCharactersButIsValidReturnsTrue()
        {
            //Arrange
            string validString = "{!@#$%^&*()_+{}|:?><,./;'[]\\=-0987654321` }";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(validString);

            //Assert

            Assert.IsTrue(isValid, "A valid string is returning false!!!");
        }

        //test to make sure special characters don't interfere with an invalid string
        [TestMethod]
        public void StringWithSpecialCharactersButIsInvalidReturnsFalse()
        {
            //Arrange
            string invalidString = "{}!@#$%^&*()_+{}|:?><,./;'[]\\=-0987654321` }";
            bool isValid;

            //Act

            isValid = StringValidator.HasMatchingBrackets(invalidString);

            //Assert

            Assert.IsFalse(isValid, "An invalid string is returning true!!!");
        }
    }
}