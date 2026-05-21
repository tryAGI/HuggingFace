
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedDatasetGatedEnum2
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
    public static class GetPapersResponseLinkedDatasetGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetGatedEnum2 value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetGatedEnum2.Auto => "auto",
                GetPapersResponseLinkedDatasetGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetPapersResponseLinkedDatasetGatedEnum2.Auto,
                "manual" => GetPapersResponseLinkedDatasetGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}