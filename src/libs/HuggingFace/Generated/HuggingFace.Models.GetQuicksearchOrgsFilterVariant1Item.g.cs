
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetQuicksearchOrgsFilterVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Own,
        /// <summary>
        /// 
        /// </summary>
        Unwatched,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetQuicksearchOrgsFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchOrgsFilterVariant1Item value)
        {
            return value switch
            {
                GetQuicksearchOrgsFilterVariant1Item.Own => "own",
                GetQuicksearchOrgsFilterVariant1Item.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchOrgsFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "own" => GetQuicksearchOrgsFilterVariant1Item.Own,
                "unwatched" => GetQuicksearchOrgsFilterVariant1Item.Unwatched,
                _ => null,
            };
        }
    }
}