
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum Mention3
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
    public static class Mention3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mention3 value)
        {
            return value switch
            {
                Mention3.All => "all",
                Mention3.Participating => "participating",
                Mention3.Mentions => "mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mention3? ToEnum(string value)
        {
            return value switch
            {
                "all" => Mention3.All,
                "participating" => Mention3.Participating,
                "mentions" => Mention3.Mentions,
                _ => null,
            };
        }
    }
}