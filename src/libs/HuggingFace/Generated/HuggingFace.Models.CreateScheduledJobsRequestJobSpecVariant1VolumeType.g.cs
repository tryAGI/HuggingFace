
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateScheduledJobsRequestJobSpecVariant1VolumeType
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
    public static class CreateScheduledJobsRequestJobSpecVariant1VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRequestJobSpecVariant1VolumeType value)
        {
            return value switch
            {
                CreateScheduledJobsRequestJobSpecVariant1VolumeType.Bucket => "bucket",
                CreateScheduledJobsRequestJobSpecVariant1VolumeType.Dataset => "dataset",
                CreateScheduledJobsRequestJobSpecVariant1VolumeType.Model => "model",
                CreateScheduledJobsRequestJobSpecVariant1VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRequestJobSpecVariant1VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateScheduledJobsRequestJobSpecVariant1VolumeType.Bucket,
                "dataset" => CreateScheduledJobsRequestJobSpecVariant1VolumeType.Dataset,
                "model" => CreateScheduledJobsRequestJobSpecVariant1VolumeType.Model,
                "space" => CreateScheduledJobsRequestJobSpecVariant1VolumeType.Space,
                _ => null,
            };
        }
    }
}