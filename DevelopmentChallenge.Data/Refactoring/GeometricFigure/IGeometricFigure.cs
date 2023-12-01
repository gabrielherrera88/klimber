namespace DevelopmentChallenge.Data.Refactoring
{
    public interface IGeometricFigure
    {
        GeometricFiguresTypes Type { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}