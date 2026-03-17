
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodChargeBilledThrough2
    {
        /// <summary>
        /// 
        /// </summary>
        StripePaymentIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePeriodChargeBilledThrough2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodChargeBilledThrough2 value)
        {
            return value switch
            {
                ResponsePeriodChargeBilledThrough2.StripePaymentIntent => "stripe-payment-intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodChargeBilledThrough2? ToEnum(string value)
        {
            return value switch
            {
                "stripe-payment-intent" => ResponsePeriodChargeBilledThrough2.StripePaymentIntent,
                _ => null,
            };
        }
    }
}