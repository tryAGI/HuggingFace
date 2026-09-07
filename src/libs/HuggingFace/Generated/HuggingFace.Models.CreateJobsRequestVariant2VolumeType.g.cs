
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateJobsRequestVariant2VolumeType
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
    public static class CreateJobsRequestVariant2VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestVariant2VolumeType value)
        {
            return value switch
            {
                CreateJobsRequestVariant2VolumeType.Bucket => "bucket",
                CreateJobsRequestVariant2VolumeType.Dataset => "dataset",
                CreateJobsRequestVariant2VolumeType.Model => "model",
                CreateJobsRequestVariant2VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestVariant2VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateJobsRequestVariant2VolumeType.Bucket,
                "dataset" => CreateJobsRequestVariant2VolumeType.Dataset,
                "model" => CreateJobsRequestVariant2VolumeType.Model,
                "space" => CreateJobsRequestVariant2VolumeType.Space,
                _ => null,
            };
        }
    }
}