
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1Gated
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
    public static class CreateCollectionsItemsResponseItemVariant1GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1Gated value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1Gated.Auto => "auto",
                CreateCollectionsItemsResponseItemVariant1Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsItemsResponseItemVariant1Gated.Auto,
                "manual" => CreateCollectionsItemsResponseItemVariant1Gated.Manual,
                _ => null,
            };
        }
    }
}