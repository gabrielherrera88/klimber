namespace DevelopmentChallenge.Data.Refactoring
{
    public class Italian : ILanguage
    {
        public string GetText(Texts type)
        {
            switch (type)
            {
                case Texts.EmptyList: return "Elenco vuoto di forme!";
                case Texts.Header: return "Rapporto sui moduli";
                case Texts.TotalTitle: return "TOTALE:";
                case Texts.Forms: return "forme";
                case Texts.Perimeter: return "Perimeter";
                case Texts.Area: return "Area";
                default: return "";
            }
        }

        public string GetText(Texts type, GeometricFiguresTypes shapeType, int count)
        {
            string shape;

            switch (shapeType)
            {
                case GeometricFiguresTypes.Square: shape = count > 1 ? "Quadrati" : "Quadrato"; break;
                case GeometricFiguresTypes.Circle: shape = count > 1 ? "Cerchi" : "Cerchio"; break;
                case GeometricFiguresTypes.Rectangle: shape = count > 1 ? "Rettangoli" : "Rettangolo"; break;
                case GeometricFiguresTypes.Triangle: shape = count > 1 ? "Triangoli" : "Triangolo"; break;
                default: shape = ""; break;
            }

            switch (type)
            {
                case Texts.Shape: return $"{count} {shape}";
                default: return "";
            }
        }
    }
}