
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan
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
    public static class GetSettingsTrustedPublishersResponseItemConfiguredByVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Academia => "academia",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Enterprise => "enterprise",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Plus => "plus",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Academia,
                "enterprise" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Enterprise,
                "plus" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Plus,
                "team" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant1Plan.Team,
                _ => null,
            };
        }
    }
}