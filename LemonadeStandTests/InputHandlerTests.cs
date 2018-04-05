using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LemonadeStand;

namespace LemonadeStandTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void GetInput_StringInListString_ReturnsTrue()
        {
            InputHandler inputHandler= new InputHandler();
            //Arrange
            List<string> options = new List<string>(new string[] { "R", "S", "C", "E" });
            string playerInput = "R";
            bool inputValidator;
            //Act
            inputValidator = inputHandler.InputValidation(options, playerInput);
            //Assert
            Assert.IsTrue(inputValidator);
        }

        [TestMethod]
        public void GetInput_StringInListString_ReturnsFalse()
        {
            InputHandler inputHandler = new InputHandler();
            //Arrange
            List<string> options = new List<string>(new string[] { "R", "S", "C", "E" });
            string playerInput = "A";
            bool inputValidator;
            //Act
            inputValidator = inputHandler.InputValidation(options, playerInput);
            //Assert
            Assert.IsFalse(inputValidator);
        }
    }
}
