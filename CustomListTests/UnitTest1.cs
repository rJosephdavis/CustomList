using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {  
        // MethodUnderTest_PathBeingTested_ExpectedResult()
        [TestMethod]
        public void Add_AddOneInt_IntGoesToIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expectedResult = 2;
            //Act
            testList.Add(2);
            //Assert
            Assert.AreEqual(expectedResult, testList[0]);

        }

        [TestMethod]
        public void Add_AddOneInt_CountGoesUpByOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expectedResult = 1;
            //Act
            testList.Add(2);
            //Assert
            Assert.AreEqual(expectedResult, testList.Count);
        }

        [TestMethod]

        public void Add_AddOneInt_CountGoesUpByFive()
        {
            CustomList<int> testList = new CustomList<int>();
            int expectedResult = 5;

            testList.add(2);

            Assert.AreEqual(expectedResult, testList.Count);
        }
        public void Add_AddOneInt_CountGoesUpByNine()
        {
            CustomList<int> testList = new CustomList<int>();
            int expectedResult = 9;

            testList.add(2);

            Assert.AreEqual(expectedResult, testList.count);
        }
            

    
            
    }




}

