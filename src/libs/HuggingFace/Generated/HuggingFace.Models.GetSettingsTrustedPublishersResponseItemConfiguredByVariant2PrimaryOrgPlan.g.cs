
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan
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
    public static class GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Academia => "academia",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Plus => "plus",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Plus,
                "team" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}