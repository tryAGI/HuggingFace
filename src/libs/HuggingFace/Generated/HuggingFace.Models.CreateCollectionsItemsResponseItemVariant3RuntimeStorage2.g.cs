
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeStorage2
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Large => "large",
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Medium => "medium",
                CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "large" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Large,
                "medium" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Medium,
                "small" => CreateCollectionsItemsResponseItemVariant3RuntimeStorage2.Small,
                _ => null,
            };
        }
    }
}