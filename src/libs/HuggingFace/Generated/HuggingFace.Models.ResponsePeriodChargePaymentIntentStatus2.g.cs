
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodChargePaymentIntentStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        RequiresCapture,
        /// <summary>
        /// 
        /// </summary>
        RequiresConfirmation,
        /// <summary>
        /// 
        /// </summary>
        RequiresPaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePeriodChargePaymentIntentStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodChargePaymentIntentStatus2 value)
        {
            return value switch
            {
                ResponsePeriodChargePaymentIntentStatus2.Canceled => "canceled",
                ResponsePeriodChargePaymentIntentStatus2.Processing => "processing",
                ResponsePeriodChargePaymentIntentStatus2.RequiresAction => "requires_action",
                ResponsePeriodChargePaymentIntentStatus2.RequiresCapture => "requires_capture",
                ResponsePeriodChargePaymentIntentStatus2.RequiresConfirmation => "requires_confirmation",
                ResponsePeriodChargePaymentIntentStatus2.RequiresPaymentMethod => "requires_payment_method",
                ResponsePeriodChargePaymentIntentStatus2.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodChargePaymentIntentStatus2? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ResponsePeriodChargePaymentIntentStatus2.Canceled,
                "processing" => ResponsePeriodChargePaymentIntentStatus2.Processing,
                "requires_action" => ResponsePeriodChargePaymentIntentStatus2.RequiresAction,
                "requires_capture" => ResponsePeriodChargePaymentIntentStatus2.RequiresCapture,
                "requires_confirmation" => ResponsePeriodChargePaymentIntentStatus2.RequiresConfirmation,
                "requires_payment_method" => ResponsePeriodChargePaymentIntentStatus2.RequiresPaymentMethod,
                "succeeded" => ResponsePeriodChargePaymentIntentStatus2.Succeeded,
                _ => null,
            };
        }
    }
}