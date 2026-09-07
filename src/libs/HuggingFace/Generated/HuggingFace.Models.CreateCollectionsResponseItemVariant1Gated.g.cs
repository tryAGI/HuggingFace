
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsResponseItemVariant1Gated
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
    public static class CreateCollectionsResponseItemVariant1GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant1Gated value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant1Gated.Auto => "auto",
                CreateCollectionsResponseItemVariant1Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant1Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsResponseItemVariant1Gated.Auto,
                "manual" => CreateCollectionsResponseItemVariant1Gated.Manual,
                _ => null,
            };
        }
    }
}