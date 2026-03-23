
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsTreeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemType value)
        {
            return value switch
            {
                GetModelsTreeResponseItemType.Directory => "directory",
                GetModelsTreeResponseItemType.File => "file",
                GetModelsTreeResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => GetModelsTreeResponseItemType.Directory,
                "file" => GetModelsTreeResponseItemType.File,
                "unknown" => GetModelsTreeResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}