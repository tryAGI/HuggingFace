
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod
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
    public static class GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod value)
        {
            return value switch
            {
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically => "charge_automatically",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice => "send_invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "charge_automatically" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically,
                "send_invoice" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice,
                _ => null,
            };
        }
    }
}