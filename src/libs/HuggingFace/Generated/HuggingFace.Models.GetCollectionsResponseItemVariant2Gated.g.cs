
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant2Gated
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
    public static class GetCollectionsResponseItemVariant2GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2Gated value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2Gated.Auto => "auto",
                GetCollectionsResponseItemVariant2Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetCollectionsResponseItemVariant2Gated.Auto,
                "manual" => GetCollectionsResponseItemVariant2Gated.Manual,
                _ => null,
            };
        }
    }
}