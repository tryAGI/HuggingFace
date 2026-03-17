
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgsFilterVariant1Item2
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
    public static class OrgsFilterVariant1Item2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsFilterVariant1Item2 value)
        {
            return value switch
            {
                OrgsFilterVariant1Item2.Own => "own",
                OrgsFilterVariant1Item2.Unwatched => "unwatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsFilterVariant1Item2? ToEnum(string value)
        {
            return value switch
            {
                "own" => OrgsFilterVariant1Item2.Own,
                "unwatched" => OrgsFilterVariant1Item2.Unwatched,
                _ => null,
            };
        }
    }
}