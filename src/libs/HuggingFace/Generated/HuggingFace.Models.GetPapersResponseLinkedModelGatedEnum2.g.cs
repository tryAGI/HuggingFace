
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelGatedEnum2
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
    public static class GetPapersResponseLinkedModelGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelGatedEnum2 value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelGatedEnum2.Auto => "auto",
                GetPapersResponseLinkedModelGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetPapersResponseLinkedModelGatedEnum2.Auto,
                "manual" => GetPapersResponseLinkedModelGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}