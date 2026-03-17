
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AuthorDataVariant1Plan2
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
    public static class ResponseDataItemVariant2AuthorDataVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AuthorDataVariant1Plan2 value)
        {
            return value switch
            {
                ResponseDataItemVariant2AuthorDataVariant1Plan2.Team => "team",
                ResponseDataItemVariant2AuthorDataVariant1Plan2.Enterprise => "enterprise",
                ResponseDataItemVariant2AuthorDataVariant1Plan2.Plus => "plus",
                ResponseDataItemVariant2AuthorDataVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AuthorDataVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant2AuthorDataVariant1Plan2.Team,
                "enterprise" => ResponseDataItemVariant2AuthorDataVariant1Plan2.Enterprise,
                "plus" => ResponseDataItemVariant2AuthorDataVariant1Plan2.Plus,
                "academia" => ResponseDataItemVariant2AuthorDataVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}