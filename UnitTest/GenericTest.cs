using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;
using System;

namespace UnitTest
{
    [TestClass]
    public class GenericTest
    {
        [TestMethod]
        public void TestMethod_One()
        {
            //Arrange
           string firstvalue = "Satya";
           string secondvalue = "Sai";
           string thirdvalue = "Ram";
            //Act
            Maximum maximum = new Maximum();
            string val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(firstvalue, val);
        }
        [TestMethod]
        public void TestMethod_Two()
        {
            //Arrange
            string firstvalue = "Arya";
            string secondvalue = "sneha";
            string thirdvalue = "Neha";
            //Act
            Maximum maximum = new Maximum();
             string val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(secondvalue, val);
        }
        [TestMethod]
        public void TestMethod_Three()
        {
            //Arrange
            string firstvalue = "Charan";
            string secondvalue = "Ram";
            string thirdvalue = "Teja";
            //Act
            Maximum maximum = new Maximum();
            string val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            //Assert
            Assert.AreEqual(thirdvalue, val);
        }

    }
}

