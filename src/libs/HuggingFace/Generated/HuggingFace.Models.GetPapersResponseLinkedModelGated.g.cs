
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPapersResponseLinkedModelGated
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
    public static class GetPapersResponseLinkedModelGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelGated value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelGated.Auto => "auto",
                GetPapersResponseLinkedModelGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetPapersResponseLinkedModelGated.Auto,
                "manual" => GetPapersResponseLinkedModelGated.Manual,
                _ => null,
            };
        }
    }
}