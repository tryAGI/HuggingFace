
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus
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
    public static class GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus value)
        {
            return value switch
            {
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Canceled => "canceled",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Processing => "processing",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresAction => "requires_action",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresCapture => "requires_capture",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresConfirmation => "requires_confirmation",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod => "requires_payment_method",
                GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Canceled,
                "processing" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Processing,
                "requires_action" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresAction,
                "requires_capture" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresCapture,
                "requires_confirmation" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresConfirmation,
                "requires_payment_method" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod,
                "succeeded" => GetSettingsBillingUsageResponsePeriodChargePaymentIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}