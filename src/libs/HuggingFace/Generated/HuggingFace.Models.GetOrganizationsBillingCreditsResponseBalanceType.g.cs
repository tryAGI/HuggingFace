
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsBillingCreditsResponseBalanceType
    {
        /// <summary>
        ///
        /// </summary>
        Granted,
        /// <summary>
        ///
        /// </summary>
        Included,
        /// <summary>
        ///
        /// </summary>
        Purchased,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsBillingCreditsResponseBalanceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingCreditsResponseBalanceType value)
        {
            return value switch
            {
                GetOrganizationsBillingCreditsResponseBalanceType.Granted => "granted",
                GetOrganizationsBillingCreditsResponseBalanceType.Included => "included",
                GetOrganizationsBillingCreditsResponseBalanceType.Purchased => "purchased",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingCreditsResponseBalanceType? ToEnum(string value)
        {
            return value switch
            {
                "granted" => GetOrganizationsBillingCreditsResponseBalanceType.Granted,
                "included" => GetOrganizationsBillingCreditsResponseBalanceType.Included,
                "purchased" => GetOrganizationsBillingCreditsResponseBalanceType.Purchased,
                _ => null,
            };
        }
    }
}