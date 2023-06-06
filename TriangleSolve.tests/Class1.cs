using NUnit.Framework;
using TriangleSolverAssignment2;

namespace TriangleSolve.tests
{
    [TestFixture]
    public class TriangleTest
    {
        private Triangle triangle;

        [SetUp]
        public void Setup()
        {
            triangle = new Triangle();
        }

        [TestFixture]
        public class TriangleTests
        {
           [Test]
            public void InvalidResponse_InvalidResponse_Test1()
            {
                // Arrange
                int a = 2, b = 3, c = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void InvalidResponse_InvalidResponse_Test2()
            {
                // Arrange
                int a = 1, b = 1, c = 3;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void InvalidResponse_InvalidResponse_Test3()
            {
                // Arrange
                int a = 5, b = 9, c = 2;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }
        }
    }
}