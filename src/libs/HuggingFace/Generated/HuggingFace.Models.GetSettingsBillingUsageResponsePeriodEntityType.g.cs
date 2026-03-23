
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsBillingUsageResponsePeriodEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsBillingUsageResponsePeriodEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingUsageResponsePeriodEntityType value)
        {
            return value switch
            {
                GetSettingsBillingUsageResponsePeriodEntityType.Org => "org",
                GetSettingsBillingUsageResponsePeriodEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingUsageResponsePeriodEntityType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetSettingsBillingUsageResponsePeriodEntityType.Org,
                "user" => GetSettingsBillingUsageResponsePeriodEntityType.User,
                _ => null,
            };
        }
    }
}