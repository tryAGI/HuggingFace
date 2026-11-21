
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan
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
    public static class GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Academia => "academia",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Enterprise => "enterprise",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Plus => "plus",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Academia,
                "enterprise" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Enterprise,
                "plus" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Plus,
                "team" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant1Plan.Team,
                _ => null,
            };
        }
    }
}