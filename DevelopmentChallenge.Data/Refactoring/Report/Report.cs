using System;

namespace DevelopmentChallenge.Data.Refactoring
{
    public sealed class ReportsFactory
    {
        public static IReport Create(ReportsTypes type)
        {
            switch (type)
            {
                case ReportsTypes.Html: return new Html();
                default: throw new ArgumentException(nameof(type));
            };
        }
    }

    public enum ReportsTypes
    {
        Html = 1,
    }
}