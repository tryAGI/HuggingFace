
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDuplicateRequestVolumeType
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
    public static class CreateDuplicateRequestVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDuplicateRequestVolumeType value)
        {
            return value switch
            {
                CreateDuplicateRequestVolumeType.Bucket => "bucket",
                CreateDuplicateRequestVolumeType.Dataset => "dataset",
                CreateDuplicateRequestVolumeType.Model => "model",
                CreateDuplicateRequestVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDuplicateRequestVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateDuplicateRequestVolumeType.Bucket,
                "dataset" => CreateDuplicateRequestVolumeType.Dataset,
                "model" => CreateDuplicateRequestVolumeType.Model,
                "space" => CreateDuplicateRequestVolumeType.Space,
                _ => null,
            };
        }
    }
}