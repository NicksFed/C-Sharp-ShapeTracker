using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System;


namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2);
      // Assert.AreEqual(typeof(Rectangle), newRectangle.GetArea());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1);
      // Act
      int result = newRectangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3);
      int newLength1 = 44;
      // Act
      newRectangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }
    
  }
}