using ShapeLib;

var circle = new Circle(11.345);
Console.WriteLine($"Circle. Radius: {circle.CircleRadius} Area: {circle.GetShapeArea()} ShapeArea: {GetShapeArea(circle)}");

var triangle = new Triangle(4,2,3);
Console.WriteLine(
	$"Triangle. Sides: {triangle.SideA}, {triangle.SideB}, {triangle.SideC} IsRightTriangle: {triangle.IsRightTriangle} Area: {triangle.GetShapeArea()} ShapeArea: {GetShapeArea(triangle)}");

triangle = new Triangle(3, 5, 4);
Console.WriteLine(
	$"Triangle. Sides: {triangle.SideA}, {triangle.SideB}, {triangle.SideC} IsRightTriangle: {triangle.IsRightTriangle} Area: {triangle.GetShapeArea()} ShapeArea: {GetShapeArea(triangle)}");


double GetShapeArea(IShapeArea shape)
{
	return shape.GetShapeArea();
}