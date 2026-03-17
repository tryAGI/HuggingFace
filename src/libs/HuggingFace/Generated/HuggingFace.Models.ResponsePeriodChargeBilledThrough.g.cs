
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodChargeBilledThrough
    {
        /// <summary>
        /// 
        /// </summary>
        StripePaymentIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePeriodChargeBilledThroughExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodChargeBilledThrough value)
        {
            return value switch
            {
                ResponsePeriodChargeBilledThrough.StripePaymentIntent => "stripe-payment-intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodChargeBilledThrough? ToEnum(string value)
        {
            return value switch
            {
                "stripe-payment-intent" => ResponsePeriodChargeBilledThrough.StripePaymentIntent,
                _ => null,
            };
        }
    }
}