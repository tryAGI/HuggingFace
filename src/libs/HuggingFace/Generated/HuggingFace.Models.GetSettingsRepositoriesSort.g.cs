
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort field (default: storage)<br/>
    /// Default Value: storage
    /// </summary>
    public enum GetSettingsRepositoriesSort
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
    public static class GetSettingsRepositoriesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsRepositoriesSort value)
        {
            return value switch
            {
                GetSettingsRepositoriesSort.Storage => "storage",
                GetSettingsRepositoriesSort.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsRepositoriesSort? ToEnum(string value)
        {
            return value switch
            {
                "storage" => GetSettingsRepositoriesSort.Storage,
                "updatedAt" => GetSettingsRepositoriesSort.UpdatedAt,
                _ => null,
            };
        }
    }
}