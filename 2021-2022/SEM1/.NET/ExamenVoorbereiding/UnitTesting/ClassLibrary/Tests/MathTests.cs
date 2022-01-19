using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add9And10Is19()
        {
            var expectedValue = 19;

            var math = new Math();

            var actualValue = math.Add(9, 10);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add5and6Is11()
        {
            var expectedValue = 11;

            var math = new Math();

            var actualValue = math.Add(5, 6);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Divide10And5Is2()
        {
            var expectedValue = 2;

            var math = new Math();

            var actualValue = math.Divide(10, 5);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Divide9And3Is3()
        {
            var expectedValue = 3;

            var math = new Math();

            var actualValue = math.Divide(9, 3);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        [DataRow(30)]
        [DataRow(5)]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZeroGivesException(int value)
        {
            var math = new Math();
            math.Divide(value, 0);
        }
    }
}
