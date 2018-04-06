using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.Collections.Generic;

namespace LemonadeStandTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void AddLemon_AddToLemonList_AddLemonsAddsToListLemons()
        {
            Inventory inventory = new Inventory();
            //Arrange
            int age = 3;
            decimal cost = 0.10m;
            int amount = 1;
            List<Lemon> actual; 

            //Act
            inventory.AddLemon(age, cost, amount);
            actual = inventory.lemons;

            //Assert
            Assert.IsInstanceOfType(actual[0], typeof(Lemon));
            
        }
    }
}
