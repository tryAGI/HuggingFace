
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3AuthorDataVariant1Plan4
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
    public static class ResponseItemVariant3AuthorDataVariant1Plan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3AuthorDataVariant1Plan4 value)
        {
            return value switch
            {
                ResponseItemVariant3AuthorDataVariant1Plan4.Team => "team",
                ResponseItemVariant3AuthorDataVariant1Plan4.Enterprise => "enterprise",
                ResponseItemVariant3AuthorDataVariant1Plan4.Plus => "plus",
                ResponseItemVariant3AuthorDataVariant1Plan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3AuthorDataVariant1Plan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3AuthorDataVariant1Plan4.Team,
                "enterprise" => ResponseItemVariant3AuthorDataVariant1Plan4.Enterprise,
                "plus" => ResponseItemVariant3AuthorDataVariant1Plan4.Plus,
                "academia" => ResponseItemVariant3AuthorDataVariant1Plan4.Academia,
                _ => null,
            };
        }
    }
}