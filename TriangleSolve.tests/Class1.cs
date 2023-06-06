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
            public void EquilateralTriangle_ValidResponse_Test()
            {
                // Arrange
                int a = 5, b = 5, c = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
            }
             [Test]
            public void IsoscelesTriangle_ValidResponse_Test1()
            {
                // Arrange
                int a = 7, b = 7, c = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void IsoscelesTriangle_ValidResponse_Test2()
            {
                // Arrange
                int a = 5, b = 6, c = 6;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void IsoscelesTriangle_ValidResponse_Test3()
            {
                // Arrange
                int a = 8, b = 6, c = 8;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }
             [Test]
            public void IsoscelesTriangle_ValidResponse_Test1()
            {
                // Arrange
                int a = 7, b = 7, c = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void IsoscelesTriangle_ValidResponse_Test2()
            {
                // Arrange
                int a = 5, b = 6, c = 6;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void IsoscelesTriangle_ValidResponse_Test3()
            {
                // Arrange
                int a = 8, b = 6, c = 8;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }
             [Test]
            public void ScaleneTriangle_ValidResponse_Test1()
            {
                // Arrange
                int a = 3, b = 4, c = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test2()
            {
                // Arrange
                int a = 7, b = 9, c = 11;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test3()
            {
                // Arrange
                int a = 5, b = 12, c = 13;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test4()
            {
                // Arrange
                int a = 10, b = 11, c = 12;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test5()
            {
                // Arrange
                int a = 2, b = 4, c = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(a, b, c);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }
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