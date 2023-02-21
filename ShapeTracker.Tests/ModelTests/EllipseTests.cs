using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
	[TestClass]
	public class EllipseTests
	{
		[TestMethod]
		public void EllipseConstructor_CreatesInstanceOfEllipse_Ellilpse()
		{
			Ellipse newEllipse = new Ellipse(2, 3);
		}

		public void GetRadius1_ReturnsRadius1_int() 
		{
			// Arrange
      int rad1 = 3;
      Ellipse newEllipse = new Ellipse(rad1, 4);
			// Act
      int result = newEllipse.Rad1;
			// Assert
      Assert.AreEqual(rad1, result);
    }
		public void SetRad1_SetsValueOfRad1_Void()
    {
      // Arrange
      Ellipse newEllipse = new Ellipse(3, 4);
      int newRad1 = 44;
      // Act
      newEllipse.Rad1 = newRad1;
      // Assert
      Assert.AreEqual(newRad1, newEllipse.Rad1);
    }
		public void GetRad2_ReturnsRad2_Int()
    {
      //Arrange
      int rad2 = 3;
      Ellipse newEllipse = new Ellipse(2, rad2);
      //Act
      int result = newEllipse.Rad2;
      //Assert
      Assert.AreEqual(rad2, result);
    }
	}
}
