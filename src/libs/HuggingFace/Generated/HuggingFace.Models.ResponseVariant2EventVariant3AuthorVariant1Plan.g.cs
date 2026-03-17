
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant3AuthorVariant1Plan
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
    public static class ResponseVariant2EventVariant3AuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant3AuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant2EventVariant3AuthorVariant1Plan.Team => "team",
                ResponseVariant2EventVariant3AuthorVariant1Plan.Enterprise => "enterprise",
                ResponseVariant2EventVariant3AuthorVariant1Plan.Plus => "plus",
                ResponseVariant2EventVariant3AuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant3AuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant2EventVariant3AuthorVariant1Plan.Team,
                "enterprise" => ResponseVariant2EventVariant3AuthorVariant1Plan.Enterprise,
                "plus" => ResponseVariant2EventVariant3AuthorVariant1Plan.Plus,
                "academia" => ResponseVariant2EventVariant3AuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}