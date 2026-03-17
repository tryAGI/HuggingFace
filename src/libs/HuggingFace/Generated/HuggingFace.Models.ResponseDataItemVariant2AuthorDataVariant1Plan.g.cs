
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AuthorDataVariant1Plan
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
    public static class ResponseDataItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseDataItemVariant2AuthorDataVariant1Plan.Team => "team",
                ResponseDataItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseDataItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                ResponseDataItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant2AuthorDataVariant1Plan.Team,
                "enterprise" => ResponseDataItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseDataItemVariant2AuthorDataVariant1Plan.Plus,
                "academia" => ResponseDataItemVariant2AuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}