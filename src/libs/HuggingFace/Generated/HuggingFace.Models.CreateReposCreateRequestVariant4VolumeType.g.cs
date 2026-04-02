
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReposCreateRequestVariant4VolumeType
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
    public static class CreateReposCreateRequestVariant4VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant4VolumeType value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant4VolumeType.Bucket => "bucket",
                CreateReposCreateRequestVariant4VolumeType.Dataset => "dataset",
                CreateReposCreateRequestVariant4VolumeType.Model => "model",
                CreateReposCreateRequestVariant4VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant4VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateReposCreateRequestVariant4VolumeType.Bucket,
                "dataset" => CreateReposCreateRequestVariant4VolumeType.Dataset,
                "model" => CreateReposCreateRequestVariant4VolumeType.Model,
                "space" => CreateReposCreateRequestVariant4VolumeType.Space,
                _ => null,
            };
        }
    }
}