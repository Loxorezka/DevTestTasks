using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShapeLib
{
	public class Circle : IShapeArea
	{
		public double CircleRadius { get; }

		public Circle(double radius)
		{
			if (radius <= 0) throw new ArgumentException($"Radius of cicle cannot be less or equal zero. Radius: {radius}");
			CircleRadius = radius;
		}

		public double GetShapeArea()
		{
			var result = CircleRadius * CircleRadius * Math.PI;
			return double.IsInfinity(result) ? -1 : result;
		}
	}
}
