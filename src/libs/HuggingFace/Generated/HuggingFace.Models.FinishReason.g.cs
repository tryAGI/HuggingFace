
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Example: Length
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        EosToken,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.EosToken => "eos_token",
                FinishReason.Length => "length",
                FinishReason.StopSequence => "stop_sequence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "eos_token" => FinishReason.EosToken,
                "length" => FinishReason.Length,
                "stop_sequence" => FinishReason.StopSequence,
                _ => null,
            };
        }
    }
}