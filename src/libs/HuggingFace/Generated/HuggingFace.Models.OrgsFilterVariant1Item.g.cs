
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgsFilterVariant1Item
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
    public static class OrgsFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsFilterVariant1Item value)
        {
            return value switch
            {
                OrgsFilterVariant1Item.Own => "own",
                OrgsFilterVariant1Item.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "own" => OrgsFilterVariant1Item.Own,
                "unwatched" => OrgsFilterVariant1Item.Unwatched,
                _ => null,
            };
        }
    }
}