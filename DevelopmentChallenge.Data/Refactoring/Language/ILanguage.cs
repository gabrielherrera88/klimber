namespace DevelopmentChallenge.Data.Refactoring
{
    public interface ILanguage
    {
        string GetText(Texts type);
        string GetText(Texts type, GeometricFiguresTypes shapeType, int count);
    }
}