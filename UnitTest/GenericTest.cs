using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;
using System;

namespace UnitTest
{
    [TestClass]
    public class GenericTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int firstvalue = 10;
            int secondvalue = 2;
            int thirdvalue = 3;
            //Act
            Maximum maximum = new Maximum();
            int val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(firstvalue, val);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int firstvalue = 10;
            int secondvalue = 20;
            int thirdvalue = 3;
            //Act
            Maximum maximum = new Maximum();
            int val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(secondvalue, val);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int firstvalue = 10;
            int secondvalue = 2;
            int thirdvalue = 30;
            //Act
            Maximum maximum=new Maximum();
            int val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(thirdvalue, val);
        }
    }
}

