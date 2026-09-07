
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateScheduledJobsRequestJobSpecVariant2VolumeType
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
    public static class CreateScheduledJobsRequestJobSpecVariant2VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRequestJobSpecVariant2VolumeType value)
        {
            return value switch
            {
                CreateScheduledJobsRequestJobSpecVariant2VolumeType.Bucket => "bucket",
                CreateScheduledJobsRequestJobSpecVariant2VolumeType.Dataset => "dataset",
                CreateScheduledJobsRequestJobSpecVariant2VolumeType.Model => "model",
                CreateScheduledJobsRequestJobSpecVariant2VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRequestJobSpecVariant2VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateScheduledJobsRequestJobSpecVariant2VolumeType.Bucket,
                "dataset" => CreateScheduledJobsRequestJobSpecVariant2VolumeType.Dataset,
                "model" => CreateScheduledJobsRequestJobSpecVariant2VolumeType.Model,
                "space" => CreateScheduledJobsRequestJobSpecVariant2VolumeType.Space,
                _ => null,
            };
        }
    }
}