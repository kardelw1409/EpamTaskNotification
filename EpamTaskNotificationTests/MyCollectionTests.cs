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
            collection.AddInEnd(addedNumber);
            //Assert
            int resultNumber = collection.First.Value;
            Assert.AreEqual(addedNumber, resultNumber, 0.001, "Invalid number in collection");
        }
    }
}
