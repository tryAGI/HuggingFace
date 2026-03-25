
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeVolumeType
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
    public static class GetCollectionsResponseItemVariant3RuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeVolumeType value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeVolumeType.Bucket => "bucket",
                GetCollectionsResponseItemVariant3RuntimeVolumeType.Dataset => "dataset",
                GetCollectionsResponseItemVariant3RuntimeVolumeType.Model => "model",
                GetCollectionsResponseItemVariant3RuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseItemVariant3RuntimeVolumeType.Bucket,
                "dataset" => GetCollectionsResponseItemVariant3RuntimeVolumeType.Dataset,
                "model" => GetCollectionsResponseItemVariant3RuntimeVolumeType.Model,
                "space" => GetCollectionsResponseItemVariant3RuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}