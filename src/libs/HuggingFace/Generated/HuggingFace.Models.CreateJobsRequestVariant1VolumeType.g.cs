
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateJobsRequestVariant1VolumeType
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
    public static class CreateJobsRequestVariant1VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestVariant1VolumeType value)
        {
            return value switch
            {
                CreateJobsRequestVariant1VolumeType.Bucket => "bucket",
                CreateJobsRequestVariant1VolumeType.Dataset => "dataset",
                CreateJobsRequestVariant1VolumeType.Model => "model",
                CreateJobsRequestVariant1VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestVariant1VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateJobsRequestVariant1VolumeType.Bucket,
                "dataset" => CreateJobsRequestVariant1VolumeType.Dataset,
                "model" => CreateJobsRequestVariant1VolumeType.Model,
                "space" => CreateJobsRequestVariant1VolumeType.Space,
                _ => null,
            };
        }
    }
}