
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus
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
    public static class GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus value)
        {
            return value switch
            {
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Canceled => "canceled",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Processing => "processing",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresAction => "requires_action",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresCapture => "requires_capture",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresConfirmation => "requires_confirmation",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod => "requires_payment_method",
                GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Canceled,
                "processing" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Processing,
                "requires_action" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresAction,
                "requires_capture" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresCapture,
                "requires_confirmation" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresConfirmation,
                "requires_payment_method" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.RequiresPaymentMethod,
                "succeeded" => GetOrganizationsBillingUsageResponsePeriodChargePaymentIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}