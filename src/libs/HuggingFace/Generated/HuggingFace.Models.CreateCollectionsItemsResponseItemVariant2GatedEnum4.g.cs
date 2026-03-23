
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2GatedEnum4
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
    public static class CreateCollectionsItemsResponseItemVariant2GatedEnum4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2GatedEnum4 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2GatedEnum4.Auto => "auto",
                CreateCollectionsItemsResponseItemVariant2GatedEnum4.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2GatedEnum4? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCollectionsItemsResponseItemVariant2GatedEnum4.Auto,
                "manual" => CreateCollectionsItemsResponseItemVariant2GatedEnum4.Manual,
                _ => null,
            };
        }
    }
}