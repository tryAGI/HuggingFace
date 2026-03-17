
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan
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
    public static class ResponseVariant1ItemItemVariant3AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Team => "team",
                ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Plus => "plus",
                ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Team,
                "enterprise" => ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Plus,
                "academia" => ResponseVariant1ItemItemVariant3AuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}