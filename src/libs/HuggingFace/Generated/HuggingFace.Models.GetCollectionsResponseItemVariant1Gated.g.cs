
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant1Gated
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
    public static class GetCollectionsResponseItemVariant1GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1Gated value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1Gated.Auto => "auto",
                GetCollectionsResponseItemVariant1Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetCollectionsResponseItemVariant1Gated.Auto,
                "manual" => GetCollectionsResponseItemVariant1Gated.Manual,
                _ => null,
            };
        }
    }
}