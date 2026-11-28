
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan
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
    public static class CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Academia => "academia",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Plus => "plus",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Plus,
                "team" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}