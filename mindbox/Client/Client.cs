using System;
using System.Collections.Generic;
using System.Text;
using mindbox.Lib;

namespace mindbox.Client
{
  class Client
  {
    public double CalculateTriangleArea(double a, double b, double c) =>
      new Triangle(a, b, c).Area;

    public double CalculateCircleArea(double r) =>
      new Circle(r).Area;

    public double CalculateShapeArea(IShape shape) =>
      shape.Area;

    public bool IsRightTriangle(double a, double b, double c) =>
      new Triangle(a, b, c).IsRight();
    
  }
}
