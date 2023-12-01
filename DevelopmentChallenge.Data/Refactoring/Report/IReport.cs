using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public interface IReport
    {
        void SetLanguage(ILanguage lenguaje);
        string GetEmptyText();
        string GetTitle();
        string GetBody(GeometricFiguresTypes type, int count, decimal area, decimal perimeter);
        string GetTotalTitle();
        string GetTotalForms(int count);
        string GetTotalArea(string value);
        string GetTotalPerimeter(string value);
    }
}