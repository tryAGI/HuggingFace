
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3RuntimeVolumeType
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
    public static class CreateCollectionsResponseItemVariant3RuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3RuntimeVolumeType value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3RuntimeVolumeType.Bucket => "bucket",
                CreateCollectionsResponseItemVariant3RuntimeVolumeType.Dataset => "dataset",
                CreateCollectionsResponseItemVariant3RuntimeVolumeType.Model => "model",
                CreateCollectionsResponseItemVariant3RuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3RuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsResponseItemVariant3RuntimeVolumeType.Bucket,
                "dataset" => CreateCollectionsResponseItemVariant3RuntimeVolumeType.Dataset,
                "model" => CreateCollectionsResponseItemVariant3RuntimeVolumeType.Model,
                "space" => CreateCollectionsResponseItemVariant3RuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}