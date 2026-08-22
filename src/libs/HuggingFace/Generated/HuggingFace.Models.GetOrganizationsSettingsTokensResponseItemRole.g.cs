
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Kind of access the token carries. `read` and `write` reach everything their owner can reach, while `fineGrained` is limited to the permissions listed under `fineGrained`
    /// </summary>
    public enum GetOrganizationsSettingsTokensResponseItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsTokensResponseItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsTokensResponseItemRole value)
        {
            return value switch
            {
                GetOrganizationsSettingsTokensResponseItemRole.FineGrained => "fineGrained",
                GetOrganizationsSettingsTokensResponseItemRole.Read => "read",
                GetOrganizationsSettingsTokensResponseItemRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsTokensResponseItemRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetOrganizationsSettingsTokensResponseItemRole.FineGrained,
                "read" => GetOrganizationsSettingsTokensResponseItemRole.Read,
                "write" => GetOrganizationsSettingsTokensResponseItemRole.Write,
                _ => null,
            };
        }
    }
}