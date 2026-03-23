
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeStorage4
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeStorage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeStorage4 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Large => "large",
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Medium => "medium",
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeStorage4? ToEnum(string value)
        {
            return value switch
            {
                "large" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Large,
                "medium" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Medium,
                "small" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage4.Small,
                _ => null,
            };
        }
    }
}