
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan
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
    public static class CreateSettingsTrustedPublishersResponseConfiguredByVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan value)
        {
            return value switch
            {
                CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Academia => "academia",
                CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Enterprise => "enterprise",
                CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Plus => "plus",
                CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Academia,
                "enterprise" => CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Enterprise,
                "plus" => CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Plus,
                "team" => CreateSettingsTrustedPublishersResponseConfiguredByVariant1Plan.Team,
                _ => null,
            };
        }
    }
}