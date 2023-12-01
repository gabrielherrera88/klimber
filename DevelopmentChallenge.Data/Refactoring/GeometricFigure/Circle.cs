using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Circle : GeometricFigures, IGeometricFigure
    {
        public Circle(decimal sideSize) : base(sideSize) { }

        public GeometricFiguresTypes Type => GeometricFiguresTypes.Circle;

        public decimal CalcularArea() => (decimal)Math.PI * (this.Side / 2) * (this.Side / 2);

        public decimal CalcularPerimetro() => (decimal)Math.PI * this.Side;
    }
}