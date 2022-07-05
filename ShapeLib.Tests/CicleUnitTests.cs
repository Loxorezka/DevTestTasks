using System;
using NUnit.Framework;

namespace ShapeLib.Tests
{
	[TestFixture]
	public class CicleUnitTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[TestCase(1)]
		[TestCase(double.MaxValue)]
		[TestCase(double.MaxValue/2.0d)]
		public void Create_Circle_Return_Object(double radius)
		{
			//Arrange

			//Act
			var circle = new Circle(radius);

			//Assert
			Assert.IsNotNull(circle);
		}

		[Test]
		[TestCase(0)]
		[TestCase(double.MinValue)]
		[TestCase(-1)]
		public void Create_Circle_Return_ArgumentException(double radius)
		{
			//Arrange

			//Act

			//Assert
			Assert.Throws<ArgumentException>(
				delegate
				{
					var circle = new Circle(radius);
				});
		}

		[Test]
		[TestCase(1d, Math.PI)]
		[TestCase(10d, 100d*Math.PI)]
		public void GetShapeArea_Return_Double(double radius, double expected)
		{
			//Arrange
			var cicle = new Circle(radius);

			//Act
			var circleArea = cicle.GetShapeArea();

			//Assert
			Assert.AreEqual(expected, circleArea);
		}

		[Test]
		[TestCase(3, Math.PI*9d)]
		[TestCase(10, 100d * Math.PI)]
		public void GetShapeArea_Check_With_Precision_Return_Double(double radius, double expected)
		{
			//Arrange
			var precision = 1E-6;
			var cicle = new Circle(radius);

			//Act
			var circleArea = cicle.GetShapeArea();

			//Assert
			Assert.AreEqual(expected,circleArea,precision);
		}

		[Test]
		[TestCase(double.MaxValue, -1)]
		public void GetShapeArea_Overload_Return_MinusOne(double radius, double expected)
		{
			//Arrange
			var cicle = new Circle(radius);

			//Act
			var circleArea = cicle.GetShapeArea();

			//Assert
			Assert.AreEqual(expected, circleArea);
		}
	}
}