namespace DevelopmentChallenge.Data.Refactoring
{
    public class Square : GeometricFigures, IGeometricFigure
    {
        public Square(decimal sideSize) : base(sideSize) { }

        public GeometricFiguresTypes Type => GeometricFiguresTypes.Square;

        public decimal CalcularArea() => this.Side * this.Side;

        public decimal CalcularPerimetro() => this.Side * 4;
    }
}