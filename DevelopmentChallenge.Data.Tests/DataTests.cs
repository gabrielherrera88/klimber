using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Refactoring;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.Spanish);
            var forma = new List<IGeometricFigure>();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.GenerarReporte(forma, reporte, language));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.English);
            var forma = new List<IGeometricFigure>();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.GenerarReporte(forma, reporte, language));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.Spanish);
            var formas = new List<IGeometricFigure> { GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 5) };

            var resumen = FormaGeometrica.GenerarReporte(formas, reporte, language);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.English);
            var cuadrados = new List<IGeometricFigure>
            {
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 5),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 1),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 3)
            };

            var resumen = FormaGeometrica.GenerarReporte(cuadrados, reporte, language);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.English);
            var formas = new List<IGeometricFigure>
            {
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 5),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 3),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 2),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 9),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 2.75m),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4.2m)
            };

            var resumen = FormaGeometrica.GenerarReporte(formas, reporte, language);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.Spanish);
            var formas = new List<IGeometricFigure>
            {
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 5),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 3),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 2),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 9),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 2.75m),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4.2m)
            };

            var resumen = FormaGeometrica.GenerarReporte(formas, reporte, language);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.Italian);
            var formas = new List<IGeometricFigure>
            {
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 5),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 3),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Square, 2),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 9),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Circle, 2.75m),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Triangle, 4.2m),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Rectangle, 10, 4)
            };

            var resumen = FormaGeometrica.GenerarReporte(formas, reporte, language);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1>2 Quadrati | Area 29 | Perimeter 28 <br/>2 Cerchi | Area 13.01 | Perimeter 18.06 <br/>3 Triangoli | Area 49.64 | Perimeter 51.6 <br/>1 Rettangolo | Area 40 | Perimeter 28 <br/>TOTALE:<br/>8 forme Perimeter 125.66 Area 131.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnItaliano()
        {
            var reporte = ReportsFactory.Create(ReportsTypes.Html);
            var language = LanguagesFactory.Create(LanguagesTypes.Italian);
            var formas = new List<IGeometricFigure>
            {
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Rectangle, 12, 5.3m),
                GeometricFiguresFactory.Create(GeometricFiguresTypes.Rectangle, 10, 4)
            };

            var resumen = FormaGeometrica.GenerarReporte(formas, reporte, language);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1>2 Rettangoli | Area 103.6 | Perimeter 62.6 <br/>TOTALE:<br/>2 forme Perimeter 62.6 Area 103.6",
                resumen);
        }
    }
}