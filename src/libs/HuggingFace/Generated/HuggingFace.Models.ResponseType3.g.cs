
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseType3
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
    public static class ResponseType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseType3 value)
        {
            return value switch
            {
                ResponseType3.Dataset => "dataset",
                ResponseType3.Model => "model",
                ResponseType3.Space => "space",
                ResponseType3.Bucket => "bucket",
                ResponseType3.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseType3? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseType3.Dataset,
                "model" => ResponseType3.Model,
                "space" => ResponseType3.Space,
                "bucket" => ResponseType3.Bucket,
                "kernel" => ResponseType3.Kernel,
                _ => null,
            };
        }
    }
}