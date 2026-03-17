
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodChargePaymentIntentStatus
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
    public static class ResponsePeriodChargePaymentIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodChargePaymentIntentStatus value)
        {
            return value switch
            {
                ResponsePeriodChargePaymentIntentStatus.Canceled => "canceled",
                ResponsePeriodChargePaymentIntentStatus.Processing => "processing",
                ResponsePeriodChargePaymentIntentStatus.RequiresAction => "requires_action",
                ResponsePeriodChargePaymentIntentStatus.RequiresCapture => "requires_capture",
                ResponsePeriodChargePaymentIntentStatus.RequiresConfirmation => "requires_confirmation",
                ResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod => "requires_payment_method",
                ResponsePeriodChargePaymentIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodChargePaymentIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ResponsePeriodChargePaymentIntentStatus.Canceled,
                "processing" => ResponsePeriodChargePaymentIntentStatus.Processing,
                "requires_action" => ResponsePeriodChargePaymentIntentStatus.RequiresAction,
                "requires_capture" => ResponsePeriodChargePaymentIntentStatus.RequiresCapture,
                "requires_confirmation" => ResponsePeriodChargePaymentIntentStatus.RequiresConfirmation,
                "requires_payment_method" => ResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod,
                "succeeded" => ResponsePeriodChargePaymentIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}