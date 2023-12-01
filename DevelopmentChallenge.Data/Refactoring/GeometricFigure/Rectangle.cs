namespace DevelopmentChallenge.Data.Refactoring
{
    public class Rectangle : GeometricFigures, IGeometricFigure
    {
        public decimal BaseSize { get; private set; }

        public Rectangle(decimal sideSize, decimal baseSize) : base(sideSize) => this.BaseSize = baseSize;

        public GeometricFiguresTypes Type => GeometricFiguresTypes.Rectangle;

        public decimal CalcularArea() => this.Side * this.BaseSize;

        public decimal CalcularPerimetro() => (this.Side * 2) + (this.BaseSize * 2);
    }
}