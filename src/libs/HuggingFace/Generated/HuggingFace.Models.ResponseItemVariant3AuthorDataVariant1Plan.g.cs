
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3AuthorDataVariant1Plan
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
    public static class ResponseItemVariant3AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3AuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseItemVariant3AuthorDataVariant1Plan.Team => "team",
                ResponseItemVariant3AuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseItemVariant3AuthorDataVariant1Plan.Plus => "plus",
                ResponseItemVariant3AuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3AuthorDataVariant1Plan.Team,
                "enterprise" => ResponseItemVariant3AuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseItemVariant3AuthorDataVariant1Plan.Plus,
                "academia" => ResponseItemVariant3AuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}