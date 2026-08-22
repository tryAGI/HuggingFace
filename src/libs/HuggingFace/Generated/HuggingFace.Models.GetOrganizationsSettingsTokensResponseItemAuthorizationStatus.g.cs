
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `pending` while the token awaits an administrator's decision, `approved` once it may act on the organization, `denied` if an administrator refused it, and `revoked` if an administrator withdrew access it had already been granted
    /// </summary>
    public enum GetOrganizationsSettingsTokensResponseItemAuthorizationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Denied,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsTokensResponseItemAuthorizationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsTokensResponseItemAuthorizationStatus value)
        {
            return value switch
            {
                GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Approved => "approved",
                GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Denied => "denied",
                GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Pending => "pending",
                GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsTokensResponseItemAuthorizationStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Approved,
                "denied" => GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Denied,
                "pending" => GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Pending,
                "revoked" => GetOrganizationsSettingsTokensResponseItemAuthorizationStatus.Revoked,
                _ => null,
            };
        }
    }
}