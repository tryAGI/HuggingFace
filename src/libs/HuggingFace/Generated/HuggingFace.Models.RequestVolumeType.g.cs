
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestVolumeType
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
    public static class RequestVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVolumeType value)
        {
            return value switch
            {
                RequestVolumeType.Bucket => "bucket",
                RequestVolumeType.Model => "model",
                RequestVolumeType.Dataset => "dataset",
                RequestVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => RequestVolumeType.Bucket,
                "model" => RequestVolumeType.Model,
                "dataset" => RequestVolumeType.Dataset,
                "space" => RequestVolumeType.Space,
                _ => null,
            };
        }
    }
}