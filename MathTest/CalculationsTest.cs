using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathTest
{
    [TestClass]
    public class CalculationsTest
    {
        [TestMethod]
        public void TestAdd()
        {
            MathCalculations math = new MathCalculations();
            double result = math.Calculate(5, 6, "Add");
            Assert.AreEqual(5, result); 
        }

        [TestMethod]
        public void TestSubtract()
        {
            MathCalculations math = new MathCalculations();
            double result = math.Calculate(5, 3, "Subtract");

           Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            MathCalculations math = new MathCalculations();
            double result = math.Calculate(6, 6, "Multiply");
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            MathCalculations math = new MathCalculations();
            double result = math.Calculate(6, 6, "Divide");
            Assert.AreEqual(1, result);
        }
    }
}
