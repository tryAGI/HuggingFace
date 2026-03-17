
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
        Length,
        /// <summary>
        /// 
        /// </summary>
        EosToken,
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
                FinishReason.Length => "length",
                FinishReason.EosToken => "eos_token",
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
                "length" => FinishReason.Length,
                "eos_token" => FinishReason.EosToken,
                "stop_sequence" => FinishReason.StopSequence,
                _ => null,
            };
        }
    }
}