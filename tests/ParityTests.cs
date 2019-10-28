using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegerHelper.UnitTest
{
    [TestClass]
    public class ParityTests
    {
        [TestMethod]
        public void TestIsEven_WithNumberTwo_ReturnTrue()
        {
            var result = 2.IsEven();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsEven_WithNumberThree_ReturnsFalse()
        {
            var result = 3.IsEven();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestToEven_WithNumberThreeAndRoundUp_ReturnsFour()
        {
            var result = 3.ToEven();
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberThreeAndRoundDown_ReturnsTwo()
        {
            var result = 3.ToEven(false);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberTwoAndRoundUp_ReturnsTwo()
        {
            var result = 2.ToEven();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberTwoAndRoundDown_ReturnsTwo()
        {
            var result = 2.ToEven(false);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberThreeAndRoundUp_ReturnsThree()
        {
            var result = 3.ToOdd();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberThreeAndRoundDown_ReturnsThree()
        {
            var result = 3.ToOdd(false);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberTwoAndRoundUp_ReturnsThree()
        {
            var result = 2.ToOdd();
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestToEven_WithNumberTwoAndRoundDown_ReturnsOne()
        {
            var result = 2.ToOdd(false);
            Assert.AreEqual(1, result);
        }
    }
}
