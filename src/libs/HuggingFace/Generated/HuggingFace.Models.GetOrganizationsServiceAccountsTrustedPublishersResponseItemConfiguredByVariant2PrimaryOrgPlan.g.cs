
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan
    {
        /// <summary>
        ///
        /// </summary>
        Academia,
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Plus,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Academia => "academia",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Plus => "plus",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Plus,
                "team" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}