using System;

namespace mindbox.Lib
{
  class Circle : IShape
  {
    private readonly double _R;

    public Circle(double r)
    {
      _R = r;
    }

    public double Area =>
       compArea();

    private double compArea() =>
       _R * _R * Math.PI;

  }
}
