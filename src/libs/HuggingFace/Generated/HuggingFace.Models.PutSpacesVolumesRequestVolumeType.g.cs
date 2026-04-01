
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesVolumesRequestVolumeType
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
    public static class PutSpacesVolumesRequestVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesVolumesRequestVolumeType value)
        {
            return value switch
            {
                PutSpacesVolumesRequestVolumeType.Bucket => "bucket",
                PutSpacesVolumesRequestVolumeType.Dataset => "dataset",
                PutSpacesVolumesRequestVolumeType.Model => "model",
                PutSpacesVolumesRequestVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesVolumesRequestVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PutSpacesVolumesRequestVolumeType.Bucket,
                "dataset" => PutSpacesVolumesRequestVolumeType.Dataset,
                "model" => PutSpacesVolumesRequestVolumeType.Model,
                "space" => PutSpacesVolumesRequestVolumeType.Space,
                _ => null,
            };
        }
    }
}