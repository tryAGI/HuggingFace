
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Filter by repository type
    /// </summary>
    public enum GetOrganizationsSettingsRepositoriesType
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
    public static class GetOrganizationsSettingsRepositoriesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsRepositoriesType value)
        {
            return value switch
            {
                GetOrganizationsSettingsRepositoriesType.Bucket => "bucket",
                GetOrganizationsSettingsRepositoriesType.Dataset => "dataset",
                GetOrganizationsSettingsRepositoriesType.Kernel => "kernel",
                GetOrganizationsSettingsRepositoriesType.Model => "model",
                GetOrganizationsSettingsRepositoriesType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsRepositoriesType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsRepositoriesType.Bucket,
                "dataset" => GetOrganizationsSettingsRepositoriesType.Dataset,
                "kernel" => GetOrganizationsSettingsRepositoriesType.Kernel,
                "model" => GetOrganizationsSettingsRepositoriesType.Model,
                "space" => GetOrganizationsSettingsRepositoriesType.Space,
                _ => null,
            };
        }
    }
}