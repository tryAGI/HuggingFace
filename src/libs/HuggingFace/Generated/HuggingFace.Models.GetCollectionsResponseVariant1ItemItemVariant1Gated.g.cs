
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant1Gated
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
    public static class GetCollectionsResponseVariant1ItemItemVariant1GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant1Gated value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant1Gated.Auto => "auto",
                GetCollectionsResponseVariant1ItemItemVariant1Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant1Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetCollectionsResponseVariant1ItemItemVariant1Gated.Auto,
                "manual" => GetCollectionsResponseVariant1ItemItemVariant1Gated.Manual,
                _ => null,
            };
        }
    }
}