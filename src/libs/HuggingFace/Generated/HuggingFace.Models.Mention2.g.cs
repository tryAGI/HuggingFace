
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum Mention2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Participating,
        /// <summary>
        /// 
        /// </summary>
        Mentions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Mention2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mention2 value)
        {
            return value switch
            {
                Mention2.All => "all",
                Mention2.Participating => "participating",
                Mention2.Mentions => "mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mention2? ToEnum(string value)
        {
            return value switch
            {
                "all" => Mention2.All,
                "participating" => Mention2.Participating,
                "mentions" => Mention2.Mentions,
                _ => null,
            };
        }
    }
}