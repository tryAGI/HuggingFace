
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2GatedEnum2
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
    public static class CreateCollectionsItemsResponseItemVariant2GatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2GatedEnum2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2GatedEnum2.Auto => "auto",
                CreateCollectionsItemsResponseItemVariant2GatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2GatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsItemsResponseItemVariant2GatedEnum2.Auto,
                "manual" => CreateCollectionsItemsResponseItemVariant2GatedEnum2.Manual,
                _ => null,
            };
        }
    }
}