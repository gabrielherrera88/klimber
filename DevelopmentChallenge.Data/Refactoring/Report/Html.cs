using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public class Html : IReport
    {
        private ILanguage lenguaje { get; set; }

        public void SetLanguage(ILanguage lenguaje) => this.lenguaje = lenguaje;

        public string GetBody(GeometricFiguresTypes type, int count, decimal area, decimal perimeter) => $"{lenguaje.GetText(Texts.Shape, type, count)} | {lenguaje.GetText(Texts.Area)} {area:#.##} | {lenguaje.GetText(Texts.Perimeter)} {perimeter:#.##} <br/>";

        public string GetEmptyText() => $"<h1>{lenguaje.GetText(Texts.EmptyList)}</h1>";

        public string GetTitle() => $"<h1>{lenguaje.GetText(Texts.Header)}</h1>";

        public string GetTotalTitle() => $"{lenguaje.GetText(Texts.TotalTitle)}<br/>";

        public string GetTotalForms(int count) => $"{count} {lenguaje.GetText(Texts.Forms)} ";

        public string GetTotalPerimeter(string value) => $"{lenguaje.GetText(Texts.Perimeter)} {value} ";

        public string GetTotalArea(string value) => $"{lenguaje.GetText(Texts.Area)} {value}";
    }
}