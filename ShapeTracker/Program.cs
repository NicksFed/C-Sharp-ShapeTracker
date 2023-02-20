using System;
using ShapeTracker.Models;
using System.Collections.Generic;
namespace ShapeTracker
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to the Shape Tracker app!");
			Console.WriteLine(
				"We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides."
			);
			Console.WriteLine("Please enter a number:");
			string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
			string stringNumber2 = Console.ReadLine();
			Console.WriteLine("Enter a third number:");
			string stringNumber3 = Console.ReadLine();
			int length1 = int.Parse(stringNumber1);
			int length2 = int.Parse(stringNumber2);
			int length3 = int.Parse(stringNumber3);
			Triangle tri = new Triangle(length1, length2, length3);
			Console.WriteLine($"the value of tri is: {tri}");
			ConfirmOrEditTriangle(tri);
		}

		static void ConfirmOrEditTriangle(Triangle tri)
		{
      Console.WriteLine(tri);
      Console.WriteLine("Please confirm that you entered in your trianlge correctly:");
			Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
			Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
			Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
			Console.WriteLine(
				"Is that correct? Enter 'yes' to proceed, or 'no' to reenter the triangle's sides"
			);
			string userInput = Console.ReadLine();
			if (userInput == "yes")
			{
				CheckTriangleType(tri);
			}
			else
			{
				Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
				Console.WriteLine("Please enter a number:");
				string stringNumber1 = Console.ReadLine();
				Console.WriteLine("Enter another number:");
				string stringNumber2 = Console.ReadLine();
				Console.WriteLine("Enter a third number:");
				string stringNumber3 = Console.ReadLine();
				tri.Side1 = int.Parse(stringNumber1);
				tri.Side2 = (int.Parse(stringNumber2));
				tri.SetSide3(int.Parse(stringNumber3));
				ConfirmOrEditTriangle(tri);
			}
		}

		static void CheckTriangleType(Triangle tri)
		{
			string result = tri.CheckType();
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Your result is: " + result + ".");
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("What's next?");
			Console.WriteLine("Would you like to check a new triangle (new)?");
			Console.WriteLine(
				"Please enter 'new' to check the type of a new triangle or to see all triangles, enter 'all'. To exit, enter any key"
			);
			string userResponse = Console.ReadLine();
			if (userResponse == "new" || userResponse == "New")
			{
				Main();
			}
			else if (userResponse == "all" || userResponse == "All")
			{
        List<Triangle> allTriangles = Triangle.GetAll();
        Type objType = allTriangles.GetType();
        for (int index = 0; index < allTriangles.Count; index++)
        // foreach (object individualEntry in allTriangles)
        {
          Console.WriteLine($"Triangle #{(index + 1)}: {allTriangles[index].Side1}, {allTriangles[index].Side2}, {allTriangles[index].GetSide3()}, {allTriangles[index].CheckType()}");
        }
      }
			else
			{
				Console.WriteLine("Goodbye!");
			}
		}
	}
}
