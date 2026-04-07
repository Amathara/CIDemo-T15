using Calculator;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        private SuperCalculator _superCalculator = new SuperCalculator();

        [TestMethod]
        public void AddNumbers()
        {
            // Arrange
            int a = 5;
            int b = 10;

            // Act
            int result = _superCalculator.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void SubtractNumbers()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            int result = _superCalculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MultiplyNumbers()
        {
            // Arrange
            int a = 5;
            int b = 10;

            // Act
            int result = _superCalculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void DivideNumbers()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            double result = _superCalculator.Divide(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideByZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => _superCalculator.Divide(a, b));
        }

        [TestMethod]
        public void Exponential()
        {
            // Arrange
            int a = 3;
            int b = 2;

            //Act
            double result = _superCalculator.Exponetial(a, b);

            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
