using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
        Triangle newTriangle = new Triangle(2);
        Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
        // Arrange
        Triangle newTriangle = new Triangle(3);
        int newLength1 = 44;
        // Act
        newTriangle.Side1 = newLength1;
        // Assert
        Assert.AreEqual(newLength1, newTriangle.Side1);
    }
        
  }
}