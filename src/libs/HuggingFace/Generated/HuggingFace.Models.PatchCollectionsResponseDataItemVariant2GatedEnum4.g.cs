
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2GatedEnum4
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
    public static class PatchCollectionsResponseDataItemVariant2GatedEnum4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2GatedEnum4 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2GatedEnum4.Auto => "auto",
                PatchCollectionsResponseDataItemVariant2GatedEnum4.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2GatedEnum4? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchCollectionsResponseDataItemVariant2GatedEnum4.Auto,
                "manual" => PatchCollectionsResponseDataItemVariant2GatedEnum4.Manual,
                _ => null,
            };
        }
    }
}