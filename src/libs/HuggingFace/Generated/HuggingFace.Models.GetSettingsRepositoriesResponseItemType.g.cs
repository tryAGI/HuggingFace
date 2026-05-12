
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsRepositoriesResponseItemType
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
        Kernel,
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
    public static class GetSettingsRepositoriesResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsRepositoriesResponseItemType value)
        {
            return value switch
            {
                GetSettingsRepositoriesResponseItemType.Bucket => "bucket",
                GetSettingsRepositoriesResponseItemType.Dataset => "dataset",
                GetSettingsRepositoriesResponseItemType.Kernel => "kernel",
                GetSettingsRepositoriesResponseItemType.Model => "model",
                GetSettingsRepositoriesResponseItemType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsRepositoriesResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSettingsRepositoriesResponseItemType.Bucket,
                "dataset" => GetSettingsRepositoriesResponseItemType.Dataset,
                "kernel" => GetSettingsRepositoriesResponseItemType.Kernel,
                "model" => GetSettingsRepositoriesResponseItemType.Model,
                "space" => GetSettingsRepositoriesResponseItemType.Space,
                _ => null,
            };
        }
    }
}