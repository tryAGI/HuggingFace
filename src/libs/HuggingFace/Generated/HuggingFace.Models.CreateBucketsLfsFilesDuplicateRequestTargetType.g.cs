
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBucketsLfsFilesDuplicateRequestTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBucketsLfsFilesDuplicateRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsLfsFilesDuplicateRequestTargetType value)
        {
            return value switch
            {
                CreateBucketsLfsFilesDuplicateRequestTargetType.Dataset => "dataset",
                CreateBucketsLfsFilesDuplicateRequestTargetType.Kernel => "kernel",
                CreateBucketsLfsFilesDuplicateRequestTargetType.Model => "model",
                CreateBucketsLfsFilesDuplicateRequestTargetType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsLfsFilesDuplicateRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateBucketsLfsFilesDuplicateRequestTargetType.Dataset,
                "kernel" => CreateBucketsLfsFilesDuplicateRequestTargetType.Kernel,
                "model" => CreateBucketsLfsFilesDuplicateRequestTargetType.Model,
                "space" => CreateBucketsLfsFilesDuplicateRequestTargetType.Space,
                _ => null,
            };
        }
    }
}