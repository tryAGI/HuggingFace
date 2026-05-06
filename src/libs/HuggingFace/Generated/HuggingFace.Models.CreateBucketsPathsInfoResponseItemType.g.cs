
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBucketsPathsInfoResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBucketsPathsInfoResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsPathsInfoResponseItemType value)
        {
            return value switch
            {
                CreateBucketsPathsInfoResponseItemType.Directory => "directory",
                CreateBucketsPathsInfoResponseItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsPathsInfoResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => CreateBucketsPathsInfoResponseItemType.Directory,
                "file" => CreateBucketsPathsInfoResponseItemType.File,
                _ => null,
            };
        }
    }
}