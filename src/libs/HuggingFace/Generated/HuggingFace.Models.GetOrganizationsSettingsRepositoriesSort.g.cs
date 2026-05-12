
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort field (default: storage)<br/>
    /// Default Value: storage
    /// </summary>
    public enum GetOrganizationsSettingsRepositoriesSort
    {
        /// <summary>
        /// storage)
        /// </summary>
        Storage,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsRepositoriesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsRepositoriesSort value)
        {
            return value switch
            {
                GetOrganizationsSettingsRepositoriesSort.Storage => "storage",
                GetOrganizationsSettingsRepositoriesSort.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsRepositoriesSort? ToEnum(string value)
        {
            return value switch
            {
                "storage" => GetOrganizationsSettingsRepositoriesSort.Storage,
                "updatedAt" => GetOrganizationsSettingsRepositoriesSort.UpdatedAt,
                _ => null,
            };
        }
    }
}