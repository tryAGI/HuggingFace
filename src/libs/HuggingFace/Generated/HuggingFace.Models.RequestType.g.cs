
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum RequestType
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
    public static class RequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestType value)
        {
            return value switch
            {
                RequestType.Dataset => "dataset",
                RequestType.Model => "model",
                RequestType.Space => "space",
                RequestType.Bucket => "bucket",
                RequestType.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RequestType.Dataset,
                "model" => RequestType.Model,
                "space" => RequestType.Space,
                "bucket" => RequestType.Bucket,
                "kernel" => RequestType.Kernel,
                _ => null,
            };
        }
    }
}