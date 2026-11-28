
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsBillingCreditsResponseBalanceType
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
    public static class GetSettingsBillingCreditsResponseBalanceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingCreditsResponseBalanceType value)
        {
            return value switch
            {
                GetSettingsBillingCreditsResponseBalanceType.Granted => "granted",
                GetSettingsBillingCreditsResponseBalanceType.Included => "included",
                GetSettingsBillingCreditsResponseBalanceType.Purchased => "purchased",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingCreditsResponseBalanceType? ToEnum(string value)
        {
            return value switch
            {
                "granted" => GetSettingsBillingCreditsResponseBalanceType.Granted,
                "included" => GetSettingsBillingCreditsResponseBalanceType.Included,
                "purchased" => GetSettingsBillingCreditsResponseBalanceType.Purchased,
                _ => null,
            };
        }
    }
}