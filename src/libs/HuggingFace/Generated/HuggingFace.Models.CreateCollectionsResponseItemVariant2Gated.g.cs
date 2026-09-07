
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2Gated
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
    public static class CreateCollectionsResponseItemVariant2GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2Gated value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2Gated.Auto => "auto",
                CreateCollectionsResponseItemVariant2Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsResponseItemVariant2Gated.Auto,
                "manual" => CreateCollectionsResponseItemVariant2Gated.Manual,
                _ => null,
            };
        }
    }
}