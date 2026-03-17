
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRepoType
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
    public static class ResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRepoType value)
        {
            return value switch
            {
                ResponseRepoType.Dataset => "dataset",
                ResponseRepoType.Model => "model",
                ResponseRepoType.Space => "space",
                ResponseRepoType.Bucket => "bucket",
                ResponseRepoType.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseRepoType.Dataset,
                "model" => ResponseRepoType.Model,
                "space" => ResponseRepoType.Space,
                "bucket" => ResponseRepoType.Bucket,
                "kernel" => ResponseRepoType.Kernel,
                _ => null,
            };
        }
    }
}