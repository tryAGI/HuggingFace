
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2Gated2
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
    public static class PatchCollectionsResponseDataItemVariant2Gated2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2Gated2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2Gated2.Auto => "auto",
                PatchCollectionsResponseDataItemVariant2Gated2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2Gated2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchCollectionsResponseDataItemVariant2Gated2.Auto,
                "manual" => PatchCollectionsResponseDataItemVariant2Gated2.Manual,
                _ => null,
            };
        }
    }
}