
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobVolumeType2
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
    public static class RequestJobVolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobVolumeType2 value)
        {
            return value switch
            {
                RequestJobVolumeType2.Bucket => "bucket",
                RequestJobVolumeType2.Model => "model",
                RequestJobVolumeType2.Dataset => "dataset",
                RequestJobVolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobVolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => RequestJobVolumeType2.Bucket,
                "model" => RequestJobVolumeType2.Model,
                "dataset" => RequestJobVolumeType2.Dataset,
                "space" => RequestJobVolumeType2.Space,
                _ => null,
            };
        }
    }
}