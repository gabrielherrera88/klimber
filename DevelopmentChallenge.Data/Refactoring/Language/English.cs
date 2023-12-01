namespace DevelopmentChallenge.Data.Refactoring
{
    public class English : ILanguage
    {
        public string GetText(Texts type)
        {
            switch (type)
            {
                case Texts.EmptyList: return "Empty list of shapes!";
                case Texts.Header: return "Shapes report";
                case Texts.TotalTitle: return "TOTAL:";
                case Texts.Forms: return "shapes";
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
                case GeometricFiguresTypes.Square: shape = count > 1 ? "Squares" : "Square"; break;
                case GeometricFiguresTypes.Circle: shape = count > 1 ? "Circles" : "Circle"; break;
                case GeometricFiguresTypes.Rectangle: shape = count > 1 ? "Rectangles" : "Rectangle"; break;
                case GeometricFiguresTypes.Triangle: shape = count > 1 ? "Triangles" : "Triangle"; break;
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