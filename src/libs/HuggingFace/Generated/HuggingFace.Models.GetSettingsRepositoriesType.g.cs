
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Filter by repository type
    /// </summary>
    public enum GetSettingsRepositoriesType
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
    public static class GetSettingsRepositoriesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsRepositoriesType value)
        {
            return value switch
            {
                GetSettingsRepositoriesType.Bucket => "bucket",
                GetSettingsRepositoriesType.Dataset => "dataset",
                GetSettingsRepositoriesType.Kernel => "kernel",
                GetSettingsRepositoriesType.Model => "model",
                GetSettingsRepositoriesType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsRepositoriesType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSettingsRepositoriesType.Bucket,
                "dataset" => GetSettingsRepositoriesType.Dataset,
                "kernel" => GetSettingsRepositoriesType.Kernel,
                "model" => GetSettingsRepositoriesType.Model,
                "space" => GetSettingsRepositoriesType.Space,
                _ => null,
            };
        }
    }
}