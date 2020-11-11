using System;

namespace mindbox
{
  class Triangle : IShape
  {
    private readonly double _A;
    private readonly double _B;
    private readonly double _C;

    public Triangle(double a, double b, double c)
    {
      if (a <= 0 || b <= 0 || c <= 0)
        throw new ArgumentException("Side must be more then zero!");

      _A = a;
      _B = b;
      _C = c;
    }

    public double Area =>
       compArea();

    private double compArea()
    {
      double p = (_A + _B + _C) / 2;
      return Math.Sqrt(p * (p - _A) * (p - _B) * (p - _C));
    }

    public bool IsRight() =>
      isRight();

    private bool isRight()
    {
      double a = _A * _A;
      double b = _B * _B;
      double c = _C * _C;
      return
        a + b - c < double.Epsilon ||
        a + c - b < double.Epsilon ||
        c + b - a < double.Epsilon;
    }
  }
}
