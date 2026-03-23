
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRequestJobSpecVolumeType
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
    public static class CreateScheduledJobsRequestJobSpecVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRequestJobSpecVolumeType value)
        {
            return value switch
            {
                CreateScheduledJobsRequestJobSpecVolumeType.Bucket => "bucket",
                CreateScheduledJobsRequestJobSpecVolumeType.Dataset => "dataset",
                CreateScheduledJobsRequestJobSpecVolumeType.Model => "model",
                CreateScheduledJobsRequestJobSpecVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRequestJobSpecVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateScheduledJobsRequestJobSpecVolumeType.Bucket,
                "dataset" => CreateScheduledJobsRequestJobSpecVolumeType.Dataset,
                "model" => CreateScheduledJobsRequestJobSpecVolumeType.Model,
                "space" => CreateScheduledJobsRequestJobSpecVolumeType.Space,
                _ => null,
            };
        }
    }
}