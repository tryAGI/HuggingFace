
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRequestOrgsFilterVariant1Item
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
    public static class CreateQuicksearchRequestOrgsFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRequestOrgsFilterVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchRequestOrgsFilterVariant1Item.Own => "own",
                CreateQuicksearchRequestOrgsFilterVariant1Item.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRequestOrgsFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "own" => CreateQuicksearchRequestOrgsFilterVariant1Item.Own,
                "unwatched" => CreateQuicksearchRequestOrgsFilterVariant1Item.Unwatched,
                _ => null,
            };
        }
    }
}