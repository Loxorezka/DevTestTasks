using System;

namespace ShapeLib
{
	public class Triangle : IShapeArea
	{
		private readonly double _sideA, _sideB, _sideC;

		private double Perimeter { get; }
	
		public double SideA => _sideA;
		public double SideB => _sideB;
		public double SideC => _sideC;

		public bool IsRightTriangle =>
			(((_sideA * _sideA - _sideB * _sideB + _sideC * _sideC) == 0) ||
			 ((_sideA * _sideA - _sideC * _sideC + _sideB * _sideB) == 0 ) || 
			 ((_sideB * _sideB - _sideA * _sideA + _sideC * _sideC) == 0 ));

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0) throw new ArgumentOutOfRangeException(nameof(sideA));
			if (sideB <= 0) throw new ArgumentOutOfRangeException(nameof(sideB));
			if (sideC <= 0) throw new ArgumentOutOfRangeException(nameof(sideC));

			if ((sideA + sideB <= sideC) || (sideB + sideC <= sideA) || (sideC + sideA <= sideB))
			{
				throw new ArgumentException($"Triangle with these sides can't exist. Sides: {sideA}, {sideB}, {sideC}");
			}
			
			_sideA = sideA;
			_sideB = sideB;
			_sideC = sideC;

			Perimeter = _sideA + sideB + sideC;
		}

		public double GetShapeArea()
		{
			double semiPerimeter = Perimeter/2.0d;

			var result = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
			return double.IsInfinity(result) ? -1 : result;
		}
	}
}
