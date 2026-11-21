
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan
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
    public static class CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Academia => "academia",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Enterprise => "enterprise",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Plus => "plus",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Academia,
                "enterprise" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Enterprise,
                "plus" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Plus,
                "team" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant1Plan.Team,
                _ => null,
            };
        }
    }
}