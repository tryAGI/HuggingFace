
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKernelsRevisionResponseGated
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
    public static class GetKernelsRevisionResponseGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseGated value)
        {
            return value switch
            {
                GetKernelsRevisionResponseGated.Auto => "auto",
                GetKernelsRevisionResponseGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetKernelsRevisionResponseGated.Auto,
                "manual" => GetKernelsRevisionResponseGated.Manual,
                _ => null,
            };
        }
    }
}