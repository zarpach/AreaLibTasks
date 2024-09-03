using AreaLib;
namespace AreaLibTests;

[TestClass]
public class AreaLibTests
{
            [TestMethod]
        public void Circle_GetArea_ShouldReturnCorrectArea()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-5, "Area calculation for Circle is incorrect.");
        }

        [TestMethod]
        [DataRow(3.0, 4.0, 5.0, 6.0)]
        [DataRow(5.0, 12.0, 13.0, 30.0)]
        public void Triangle_GetArea_ShouldReturnCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 1e-5, "Area calculation for Triangle is incorrect.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_InvalidSides_ShouldThrowArgumentException()
        {
            // Arrange & Act
            new Triangle(1.0, 2.0, 10.0);
            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Circle_InvalidRadius_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange & Act
            new Circle(-5.0);
            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [DataRow(16.0, 30.0, 34.0, true)]
        [DataRow(8.0, 12.0, 16.0, false)]
        [DataRow(15.0, 20.0, 25.0, true)]
        public void Triangle_ShouldCheckIsRightAngled(double sideA, double sideB, double sideC, bool isRightAngled) 
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool IsRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.AreEqual(isRightAngled, IsRightAngled);
        }
}