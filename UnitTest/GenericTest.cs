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
            float firstvalue = 7.3f;
            float secondvalue = 2.3f;
            float thirdvalue = 3.4f;
            //Act
            Maximum maximum = new Maximum();
            float val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(firstvalue, val);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            float firstvalue = 1.0f;
            float secondvalue = 2.2f;
            float thirdvalue = 1.3f;
            //Act
            Maximum maximum = new Maximum();
            float val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(secondvalue, val);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            float firstvalue = 1.0f;
            float secondvalue = 2.1f;
            float thirdvalue = 3.4f;
            //Act
            Maximum maximum=new Maximum();
            float val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(thirdvalue, val);
        }
    }
}

