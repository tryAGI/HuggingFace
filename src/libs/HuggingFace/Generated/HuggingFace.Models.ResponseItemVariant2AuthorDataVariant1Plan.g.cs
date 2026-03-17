
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AuthorDataVariant1Plan
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
    public static class ResponseItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseItemVariant2AuthorDataVariant1Plan.Team => "team",
                ResponseItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                ResponseItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant2AuthorDataVariant1Plan.Team,
                "enterprise" => ResponseItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseItemVariant2AuthorDataVariant1Plan.Plus,
                "academia" => ResponseItemVariant2AuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}