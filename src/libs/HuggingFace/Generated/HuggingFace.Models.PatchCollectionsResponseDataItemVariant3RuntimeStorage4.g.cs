
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeStorage4
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeStorage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeStorage4 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Large => "large",
                PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Medium => "medium",
                PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeStorage4? ToEnum(string value)
        {
            return value switch
            {
                "large" => PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Large,
                "medium" => PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Medium,
                "small" => PatchCollectionsResponseDataItemVariant3RuntimeStorage4.Small,
                _ => null,
            };
        }
    }
}