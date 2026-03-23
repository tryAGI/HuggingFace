
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchOrgsFilterVariant1Item
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
    public static class CreateQuicksearchOrgsFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchOrgsFilterVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchOrgsFilterVariant1Item.Own => "own",
                CreateQuicksearchOrgsFilterVariant1Item.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchOrgsFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "own" => CreateQuicksearchOrgsFilterVariant1Item.Own,
                "unwatched" => CreateQuicksearchOrgsFilterVariant1Item.Unwatched,
                _ => null,
            };
        }
    }
}