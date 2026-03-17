
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewTitleAuthorVariant1Plan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseNewTitleAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewTitleAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseNewTitleAuthorVariant1Plan.Team => "team",
                ResponseNewTitleAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseNewTitleAuthorVariant1Plan.Plus => "plus",
                ResponseNewTitleAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewTitleAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewTitleAuthorVariant1Plan.Team,
                "enterprise" => ResponseNewTitleAuthorVariant1Plan.Enterprise,
                "plus" => ResponseNewTitleAuthorVariant1Plan.Plus,
                "academia" => ResponseNewTitleAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}