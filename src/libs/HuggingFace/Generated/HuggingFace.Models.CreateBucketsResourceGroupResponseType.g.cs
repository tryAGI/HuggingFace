
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBucketsResourceGroupResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
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
    public static class CreateBucketsResourceGroupResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBucketsResourceGroupResponseType value)
        {
            return value switch
            {
                CreateBucketsResourceGroupResponseType.Bucket => "bucket",
                CreateBucketsResourceGroupResponseType.Dataset => "dataset",
                CreateBucketsResourceGroupResponseType.Kernel => "kernel",
                CreateBucketsResourceGroupResponseType.Model => "model",
                CreateBucketsResourceGroupResponseType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBucketsResourceGroupResponseType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateBucketsResourceGroupResponseType.Bucket,
                "dataset" => CreateBucketsResourceGroupResponseType.Dataset,
                "kernel" => CreateBucketsResourceGroupResponseType.Kernel,
                "model" => CreateBucketsResourceGroupResponseType.Model,
                "space" => CreateBucketsResourceGroupResponseType.Space,
                _ => null,
            };
        }
    }
}