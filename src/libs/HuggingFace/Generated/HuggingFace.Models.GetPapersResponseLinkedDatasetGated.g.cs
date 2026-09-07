
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPapersResponseLinkedDatasetGated
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
    public static class GetPapersResponseLinkedDatasetGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetGated value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetGated.Auto => "auto",
                GetPapersResponseLinkedDatasetGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetPapersResponseLinkedDatasetGated.Auto,
                "manual" => GetPapersResponseLinkedDatasetGated.Manual,
                _ => null,
            };
        }
    }
}