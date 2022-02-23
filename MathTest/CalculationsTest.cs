using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
