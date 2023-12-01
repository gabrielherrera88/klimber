using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public sealed class LanguagesFactory
    {
        public static ILanguage Create(LanguagesTypes type)
        {
            switch (type)
            {
                case LanguagesTypes.Spanish: return new Spanish();
                case LanguagesTypes.English: return new English();
                case LanguagesTypes.Italian: return new Italian();
                default: throw new ArgumentException(nameof(type));
            }
        }
    }

    public enum LanguagesTypes
    {
        Spanish = 1,
        English = 2,
        Italian = 3,
    }

    public enum Texts
    {
        EmptyList = 1,
        Header = 2,
        TotalTitle = 3,
        Forms = 4,
        Perimeter = 5,
        Area = 6,
        Shape = 7,
    }
}