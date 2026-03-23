
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ChargeAutomatically,
        /// <summary>
        /// 
        /// </summary>
        SendInvoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod value)
        {
            return value switch
            {
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically => "charge_automatically",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice => "send_invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "charge_automatically" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically,
                "send_invoice" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice,
                _ => null,
            };
        }
    }
}