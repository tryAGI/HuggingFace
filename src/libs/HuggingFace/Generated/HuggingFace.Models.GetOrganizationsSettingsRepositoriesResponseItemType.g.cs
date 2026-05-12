
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsSettingsRepositoriesResponseItemType
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
    public static class GetOrganizationsSettingsRepositoriesResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsRepositoriesResponseItemType value)
        {
            return value switch
            {
                GetOrganizationsSettingsRepositoriesResponseItemType.Bucket => "bucket",
                GetOrganizationsSettingsRepositoriesResponseItemType.Dataset => "dataset",
                GetOrganizationsSettingsRepositoriesResponseItemType.Kernel => "kernel",
                GetOrganizationsSettingsRepositoriesResponseItemType.Model => "model",
                GetOrganizationsSettingsRepositoriesResponseItemType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsRepositoriesResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsRepositoriesResponseItemType.Bucket,
                "dataset" => GetOrganizationsSettingsRepositoriesResponseItemType.Dataset,
                "kernel" => GetOrganizationsSettingsRepositoriesResponseItemType.Kernel,
                "model" => GetOrganizationsSettingsRepositoriesResponseItemType.Model,
                "space" => GetOrganizationsSettingsRepositoriesResponseItemType.Space,
                _ => null,
            };
        }
    }
}