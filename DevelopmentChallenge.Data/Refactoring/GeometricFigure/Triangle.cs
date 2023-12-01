using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Triangle : GeometricFigures, IGeometricFigure
    {
        public Triangle(decimal sideSize) : base(sideSize) { }

        public GeometricFiguresTypes Type => GeometricFiguresTypes.Triangle;

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * this.Side * this.Side;

        public decimal CalcularPerimetro() => this.Side * 3;
    }
}