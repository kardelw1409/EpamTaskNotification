using System;
using EpamTaskNotification.NewCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpamTaskNotificationTests
{
    [TestClass]
    public class MyCollectionTests
    {
        [TestMethod]
        public void AddInEnd_AddInEndOneElement_OneElementAdded()
        {
            //Arrange
            var collection = new MyCollection<int>();
            int addedNumber = 5;
            //Act
            collection.Add(addedNumber);
            //Assert
            int resultNumber = collection.First.Value;
            int resultCount = collection.Count;
            Assert.AreEqual(1, resultCount, 0.001, "Invalid count in collection");
            Assert.AreEqual(addedNumber, resultNumber, 0.001, "Invalid number in collection");
        }

        [TestMethod]
        public void RemoveInEnd_RemoveInEndOneElement_OneElementRemove()
        {
            //Arrange
            int firstNum = 9;
            int secondNum = 10;
            var collection = new MyCollection<int> { firstNum, secondNum };
            //Act
            collection.RemoveLast();
            //Assert
            int resultCount = collection.Count;
            int result = collection.First.Value;
            Assert.AreEqual(1, resultCount, 0.001, "Invalid count in collection");
            Assert.AreEqual(firstNum, result, 0.001, "Invalid number in collection");

        }
        [TestMethod]
        public void Count_CountTwoElement_TwoElementResult()
        {
            //Arrange
            int firstNum = 5;
            int secondNum = 6;
            var collection = new MyCollection<int> { firstNum, secondNum };
            //Act
            int result = collection.Count;
            //Assert
            Assert.AreEqual(2, result, 0.001, "Invalid count in collection");
        }
    }
}
