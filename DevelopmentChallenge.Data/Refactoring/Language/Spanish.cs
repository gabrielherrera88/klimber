namespace DevelopmentChallenge.Data.Refactoring
{
    public class Spanish : ILanguage
    {
        public string GetText(Texts type)
        {
            switch (type)
            {
                case Texts.EmptyList: return "Lista vacía de formas!";
                case Texts.Header: return "Reporte de Formas";
                case Texts.TotalTitle: return "TOTAL:";
                case Texts.Forms: return "formas";
                case Texts.Perimeter: return "Perimetro";
                case Texts.Area: return "Area";
                default: return "";
            }
        }

        public string GetText(Texts type, GeometricFiguresTypes shapeType, int count)
        {
            string shape;

            switch (shapeType)
            {
                case GeometricFiguresTypes.Square: shape = count > 1 ? "Cuadrados" : "Cuadrado"; break;
                case GeometricFiguresTypes.Circle: shape = count > 1 ? "Círculos" : "Circulo"; break;
                case GeometricFiguresTypes.Rectangle: shape = count > 1 ? "Rectangulos" : "Rectangulo"; break;
                case GeometricFiguresTypes.Triangle: shape = count > 1 ? "Triángulos" : "Triangulo"; break;
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