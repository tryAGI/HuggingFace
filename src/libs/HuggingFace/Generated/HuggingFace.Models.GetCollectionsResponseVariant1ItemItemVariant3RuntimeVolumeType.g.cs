
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType
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
    public static class GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Bucket => "bucket",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Dataset => "dataset",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Model => "model",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Bucket,
                "dataset" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Dataset,
                "model" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Model,
                "space" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}