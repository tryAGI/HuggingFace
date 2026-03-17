
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobSpecVolumeType
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
    public static class RequestJobSpecVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobSpecVolumeType value)
        {
            return value switch
            {
                RequestJobSpecVolumeType.Bucket => "bucket",
                RequestJobSpecVolumeType.Model => "model",
                RequestJobSpecVolumeType.Dataset => "dataset",
                RequestJobSpecVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobSpecVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => RequestJobSpecVolumeType.Bucket,
                "model" => RequestJobSpecVolumeType.Model,
                "dataset" => RequestJobSpecVolumeType.Dataset,
                "space" => RequestJobSpecVolumeType.Space,
                _ => null,
            };
        }
    }
}