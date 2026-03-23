
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3RuntimeStorage2
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
    public static class CreateCollectionsResponseItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3RuntimeStorage2.Large => "large",
                CreateCollectionsResponseItemVariant3RuntimeStorage2.Medium => "medium",
                CreateCollectionsResponseItemVariant3RuntimeStorage2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "large" => CreateCollectionsResponseItemVariant3RuntimeStorage2.Large,
                "medium" => CreateCollectionsResponseItemVariant3RuntimeStorage2.Medium,
                "small" => CreateCollectionsResponseItemVariant3RuntimeStorage2.Small,
                _ => null,
            };
        }
    }
}