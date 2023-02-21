using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;


namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 2);
      // Act
      int result = newRectangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3,3);
      int newLength1 = 44;
      // Act
      newRectangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      //Arrange
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(2, length2);
      //Act
      int result = newRectangle.Side2;
      //Assert
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3,4);
      int newLength2 = 6;
      // Act
      newRectangle.Side2 = newLength2;
      // Assert
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    public void GetArea_DeterminesTheAreaOfARectangle_Int()
    {
      // Arrange
      Rectangle rectangleArea = new Rectangle(3, 4);
      // Action 
      int recArea = rectangleArea.GetArea();
      // Assert
      Assert.AreEqual(12, rectangleArea);
    }
  }
}