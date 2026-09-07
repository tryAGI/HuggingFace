
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKernelsResponseGated
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseGated value)
        {
            return value switch
            {
                GetKernelsResponseGated.Auto => "auto",
                GetKernelsResponseGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetKernelsResponseGated.Auto,
                "manual" => GetKernelsResponseGated.Manual,
                _ => null,
            };
        }
    }
}