
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort direction (default: desc)<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetOrganizationsSettingsRepositoriesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// desc)
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsRepositoriesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsRepositoriesDirection value)
        {
            return value switch
            {
                GetOrganizationsSettingsRepositoriesDirection.Asc => "asc",
                GetOrganizationsSettingsRepositoriesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsRepositoriesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetOrganizationsSettingsRepositoriesDirection.Asc,
                "desc" => GetOrganizationsSettingsRepositoriesDirection.Desc,
                _ => null,
            };
        }
    }
}