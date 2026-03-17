
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobVolumeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestJobVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobVolumeType value)
        {
            return value switch
            {
                RequestJobVolumeType.Bucket => "bucket",
                RequestJobVolumeType.Model => "model",
                RequestJobVolumeType.Dataset => "dataset",
                RequestJobVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => RequestJobVolumeType.Bucket,
                "model" => RequestJobVolumeType.Model,
                "dataset" => RequestJobVolumeType.Dataset,
                "space" => RequestJobVolumeType.Space,
                _ => null,
            };
        }
    }
}