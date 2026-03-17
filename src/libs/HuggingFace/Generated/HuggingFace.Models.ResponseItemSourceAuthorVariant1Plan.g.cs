
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSourceAuthorVariant1Plan
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
    public static class ResponseItemSourceAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSourceAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseItemSourceAuthorVariant1Plan.Team => "team",
                ResponseItemSourceAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseItemSourceAuthorVariant1Plan.Plus => "plus",
                ResponseItemSourceAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSourceAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemSourceAuthorVariant1Plan.Team,
                "enterprise" => ResponseItemSourceAuthorVariant1Plan.Enterprise,
                "plus" => ResponseItemSourceAuthorVariant1Plan.Plus,
                "academia" => ResponseItemSourceAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}