
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsSettingsRepositoriesResponseItemVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsRepositoriesResponseItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsRepositoriesResponseItemVisibility value)
        {
            return value switch
            {
                GetOrganizationsSettingsRepositoriesResponseItemVisibility.Private => "private",
                GetOrganizationsSettingsRepositoriesResponseItemVisibility.Protected => "protected",
                GetOrganizationsSettingsRepositoriesResponseItemVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsRepositoriesResponseItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetOrganizationsSettingsRepositoriesResponseItemVisibility.Private,
                "protected" => GetOrganizationsSettingsRepositoriesResponseItemVisibility.Protected,
                "public" => GetOrganizationsSettingsRepositoriesResponseItemVisibility.Public,
                _ => null,
            };
        }
    }
}