using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ErbiumCustomListProj;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//add tests 1
        public void Add_PositiveNumbers_CountOfOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;
            //Act
            myList.Add(value1);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//2
        public void Add_PositiveNumbers_CountOfFour()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;
            int expected = 4;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//3
        public void Add_PositiveNumbers_CapacityOfFour()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;
            int expected = 4;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//4
        public void Add_PositiveNumbers_CapacityIncreases()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;
            int value5 = 2;
            int expected = 8;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//5
        public void Add_PositiveNumbers_CapacityDoubles()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;
            int value5 = 2;
            int expected = 8;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Indexer tests
        
        [TestMethod]//1
        public void Access_IteminList_ItemCaptured()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 0;
            int expected = 2;
            int actual;
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//2

        public void Access_IteminList_ItemSet()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 0;
            int expected = 20;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList[0] = 20;
            actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//3
        public void Access_IteminList_ItemGet()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 0;
            int expected = 6;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList[0] = 20;
            actual = myList[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//4
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Index_ExcpetionThrown()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 0;
            int expected = 6;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList[0] = 20;
            actual = myList[10];
            
        }
        [TestMethod]//5
        public void ChangeType_IteminList_ToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 0;
            int expected = 6;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList[0] = 20;
            actual = myList[2];
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod] //Remove tests test 1
        public void Remove_ItemInList_CountDecreaseOfOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;
            int expected = 3;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(value3);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //test 2
        public void Remove_ItemInList_IndexDecreases()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 4;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(2);
            actual = myList[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //test 3
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_ItemInList_ReturnsValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 3;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(1);
            actual = myList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //test 4
        public void Remove_ItemInList_ItemsMoveUpASlot()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int expected = 6;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(myList[1]);
            actual = myList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //test 5
        public void Remove_ItemInList_AbilityToRemoveFirstItem()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int expected = 4;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(2);
            actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
