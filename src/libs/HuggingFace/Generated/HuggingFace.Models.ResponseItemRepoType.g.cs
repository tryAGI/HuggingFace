
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemRepoType value)
        {
            return value switch
            {
                ResponseItemRepoType.Dataset => "dataset",
                ResponseItemRepoType.Model => "model",
                ResponseItemRepoType.Space => "space",
                ResponseItemRepoType.Bucket => "bucket",
                ResponseItemRepoType.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemRepoType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseItemRepoType.Dataset,
                "model" => ResponseItemRepoType.Model,
                "space" => ResponseItemRepoType.Space,
                "bucket" => ResponseItemRepoType.Bucket,
                "kernel" => ResponseItemRepoType.Kernel,
                _ => null,
            };
        }
    }
}