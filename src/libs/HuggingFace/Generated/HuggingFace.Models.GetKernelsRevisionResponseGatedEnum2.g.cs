
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsRevisionResponseGatedEnum2
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
    public static class GetKernelsRevisionResponseGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseGatedEnum2 value)
        {
            return value switch
            {
                GetKernelsRevisionResponseGatedEnum2.Auto => "auto",
                GetKernelsRevisionResponseGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetKernelsRevisionResponseGatedEnum2.Auto,
                "manual" => GetKernelsRevisionResponseGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}