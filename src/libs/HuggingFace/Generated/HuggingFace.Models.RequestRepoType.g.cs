
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestRepoType
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
    public static class RequestRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestRepoType value)
        {
            return value switch
            {
                RequestRepoType.Dataset => "dataset",
                RequestRepoType.Model => "model",
                RequestRepoType.Space => "space",
                RequestRepoType.Bucket => "bucket",
                RequestRepoType.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestRepoType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RequestRepoType.Dataset,
                "model" => RequestRepoType.Model,
                "space" => RequestRepoType.Space,
                "bucket" => RequestRepoType.Bucket,
                "kernel" => RequestRepoType.Kernel,
                _ => null,
            };
        }
    }
}