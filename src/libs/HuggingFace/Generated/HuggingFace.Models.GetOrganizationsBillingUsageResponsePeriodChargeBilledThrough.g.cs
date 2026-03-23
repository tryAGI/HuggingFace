
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough
    {
        /// <summary>
        /// 
        /// </summary>
        StripePaymentIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsBillingUsageResponsePeriodChargeBilledThroughExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough value)
        {
            return value switch
            {
                GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough.StripePaymentIntent => "stripe-payment-intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough? ToEnum(string value)
        {
            return value switch
            {
                "stripe-payment-intent" => GetOrganizationsBillingUsageResponsePeriodChargeBilledThrough.StripePaymentIntent,
                _ => null,
            };
        }
    }
}