
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1Gated
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
    public static class PatchCollectionsResponseDataItemVariant1GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1Gated value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1Gated.Auto => "auto",
                PatchCollectionsResponseDataItemVariant1Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchCollectionsResponseDataItemVariant1Gated.Auto,
                "manual" => PatchCollectionsResponseDataItemVariant1Gated.Manual,
                _ => null,
            };
        }
    }
}