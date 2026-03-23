
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsRequestVolumeType
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
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateJobsRequestVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestVolumeType value)
        {
            return value switch
            {
                CreateJobsRequestVolumeType.Bucket => "bucket",
                CreateJobsRequestVolumeType.Dataset => "dataset",
                CreateJobsRequestVolumeType.Model => "model",
                CreateJobsRequestVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateJobsRequestVolumeType.Bucket,
                "dataset" => CreateJobsRequestVolumeType.Dataset,
                "model" => CreateJobsRequestVolumeType.Model,
                "space" => CreateJobsRequestVolumeType.Space,
                _ => null,
            };
        }
    }
}