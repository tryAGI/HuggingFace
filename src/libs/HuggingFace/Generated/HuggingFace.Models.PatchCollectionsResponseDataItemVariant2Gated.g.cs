
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2Gated
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
    public static class PatchCollectionsResponseDataItemVariant2GatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2Gated value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2Gated.Auto => "auto",
                PatchCollectionsResponseDataItemVariant2Gated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2Gated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchCollectionsResponseDataItemVariant2Gated.Auto,
                "manual" => PatchCollectionsResponseDataItemVariant2Gated.Manual,
                _ => null,
            };
        }
    }
}