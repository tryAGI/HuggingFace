
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum TruncationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TruncationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TruncationDirection value)
        {
            return value switch
            {
                TruncationDirection.Left => "Left",
                TruncationDirection.Right => "Right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TruncationDirection? ToEnum(string value)
        {
            return value switch
            {
                "Left" => TruncationDirection.Left,
                "Right" => TruncationDirection.Right,
                _ => null,
            };
        }
    }
}