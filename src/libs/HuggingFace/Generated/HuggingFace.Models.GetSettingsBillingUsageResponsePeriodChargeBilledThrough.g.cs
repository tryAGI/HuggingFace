
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsBillingUsageResponsePeriodChargeBilledThrough
    {
        /// <summary>
        /// 
        /// </summary>
        StripePaymentIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsBillingUsageResponsePeriodChargeBilledThroughExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingUsageResponsePeriodChargeBilledThrough value)
        {
            return value switch
            {
                GetSettingsBillingUsageResponsePeriodChargeBilledThrough.StripePaymentIntent => "stripe-payment-intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingUsageResponsePeriodChargeBilledThrough? ToEnum(string value)
        {
            return value switch
            {
                "stripe-payment-intent" => GetSettingsBillingUsageResponsePeriodChargeBilledThrough.StripePaymentIntent,
                _ => null,
            };
        }
    }
}