using System;
using NUnit.Framework;

namespace ShapeLib.Tests;

[TestFixture]
public class TriangleUnitTests
{
	[Test]
	[Parallelizable]
	[TestCase(1,1,1)]
	[TestCase(100,200,150)]
	public void Create_Triangle_Return_Object(double sideA, double sideB, double sideC)
	{
		//Arrange

		//Act
		var triangle = new Triangle(sideA,sideB, sideC);

		//Assert
		Assert.IsNotNull(triangle);
		Assert.AreEqual(sideA,triangle.SideA,0);
		Assert.AreEqual(sideB, triangle.SideB, 0);
		Assert.AreEqual(sideC, triangle.SideC, 0);
	}

	[Test]
	[Parallelizable]
	[TestCase(1, 1, 2)]
	[TestCase(10, 15, 30)]
	public void Create_Triangle__Return_ArgumentException(double sideA, double sideB, double sideC)
	{
		//Arrange

		//Act

		//Assert
		Assert.Throws<ArgumentException>(
			delegate
			{
				var triangle = new Triangle(sideA, sideB, sideC);
			});
	}

	[Test]
	[Parallelizable]
	[TestCase(-1, 1, 1)]
	[TestCase(1, -1, 1)]
	[TestCase(1, 1, -1)]
	public void Create_Triangle__Return_ArgumentOutOfRangeException(double sideA, double sideB, double sideC)
	{
		//Arrange

		//Act

		//Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			delegate
			{
				var triangle = new Triangle(sideA, sideB, sideC);
			});
	}

	[Test]
	[Parallelizable]
	[TestCase(4,2,3, 2.9047375096555625, 1E-6)]
	[TestCase(3, 5,4,6,0)]
	public void GetShapeArea_Check_With_Precision_Return_Double(double sideA, double sideB, double sideC, double expected, double precision)
	{
		//Arrange
		var triangle = new Triangle(sideA, sideB, sideC);

		//Act
		var triangleArea = triangle.GetShapeArea();

		//Assert
		Assert.AreEqual(expected, triangleArea, precision);
	}

	[Test]
	[TestCase(double.MaxValue, double.MaxValue, double.MaxValue, -1)]
	public void GetShapeArea_Overload_Return_MinusOne(double sideA, double sideB, double sideC, double expected)
	{
		//Arrange
		var triangle = new Triangle(sideA, sideB, sideC);

		//Act
		var triangleArea = triangle.GetShapeArea();

		//Assert
		Assert.AreEqual(expected, triangleArea);
	}

	[Test]
	[Parallelizable]
	[TestCase(4, 2, 3, false)]
	[TestCase(3, 5, 4, true)]
	public void Triangle_Check_is_RightTriangle_Return_Bool(double sideA, double sideB, double sideC, bool expected)
	{
		//Arrange
		var triangle = new Triangle(sideA, sideB, sideC);

		//Act
		var isRightTriangle = triangle.IsRightTriangle;

		//Assert
		Assert.True(expected == isRightTriangle);
	}
}
