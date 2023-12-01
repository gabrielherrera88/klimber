using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class GeometricFigures
    {
        internal readonly decimal Side;

        public GeometricFigures(decimal sideSize) => this.Side = sideSize;
    }

    public sealed class GeometricFiguresFactory
    {
        public static IGeometricFigure Create(GeometricFiguresTypes type, decimal sideSize, decimal baseSize = 0)
        {
            switch (type)
            {
                case GeometricFiguresTypes.Circle: return new Circle(sideSize);
                case GeometricFiguresTypes.Rectangle: return new Rectangle(sideSize, baseSize);
                case GeometricFiguresTypes.Square: return new Square(sideSize);
                case GeometricFiguresTypes.Triangle: return new Triangle(sideSize);
                default: throw new ArgumentException(nameof(type));
            }
        }
    }

    public enum GeometricFiguresTypes
    {
        Circle = 1,
        Rectangle = 2,
        Square = 3,
        Triangle = 5
    }
}