
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1Gated2
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
    public static class CreateCollectionsItemsResponseItemVariant1Gated2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1Gated2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1Gated2.Auto => "auto",
                CreateCollectionsItemsResponseItemVariant1Gated2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1Gated2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsItemsResponseItemVariant1Gated2.Auto,
                "manual" => CreateCollectionsItemsResponseItemVariant1Gated2.Manual,
                _ => null,
            };
        }
    }
}