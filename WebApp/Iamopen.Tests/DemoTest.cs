using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Iamopen.Tests
{
    [TestFixture]
    public class DemoTestClass
    {
        [Test]
        public void DemoTest()
        {
            // Arrange
            int data = 5;

            // Act
            int actualResult = data + 2;
                          
            // Assert
            int expectedResult = 7;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
