
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsBillingUsageResponsePeriodEntityType
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
    public static class GetOrganizationsBillingUsageResponsePeriodEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingUsageResponsePeriodEntityType value)
        {
            return value switch
            {
                GetOrganizationsBillingUsageResponsePeriodEntityType.Org => "org",
                GetOrganizationsBillingUsageResponsePeriodEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingUsageResponsePeriodEntityType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetOrganizationsBillingUsageResponsePeriodEntityType.Org,
                "user" => GetOrganizationsBillingUsageResponsePeriodEntityType.User,
                _ => null,
            };
        }
    }
}