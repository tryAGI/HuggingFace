
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1GatedEnum2
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
    public static class PatchCollectionsResponseDataItemVariant1GatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1GatedEnum2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1GatedEnum2.Auto => "auto",
                PatchCollectionsResponseDataItemVariant1GatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1GatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchCollectionsResponseDataItemVariant1GatedEnum2.Auto,
                "manual" => PatchCollectionsResponseDataItemVariant1GatedEnum2.Manual,
                _ => null,
            };
        }
    }
}