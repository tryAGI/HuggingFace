
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestOrgsFilterVariant1Item
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
    public static class RequestOrgsFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOrgsFilterVariant1Item value)
        {
            return value switch
            {
                RequestOrgsFilterVariant1Item.Own => "own",
                RequestOrgsFilterVariant1Item.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOrgsFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "own" => RequestOrgsFilterVariant1Item.Own,
                "unwatched" => RequestOrgsFilterVariant1Item.Unwatched,
                _ => null,
            };
        }
    }
}