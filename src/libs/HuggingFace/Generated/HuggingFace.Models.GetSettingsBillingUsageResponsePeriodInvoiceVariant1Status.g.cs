
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        Uncollectible,
        /// <summary>
        /// 
        /// </summary>
        Unpaid,
        /// <summary>
        /// 
        /// </summary>
        Void,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsBillingUsageResponsePeriodInvoiceVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status value)
        {
            return value switch
            {
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Draft => "draft",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Open => "open",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Paid => "paid",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Uncollectible => "uncollectible",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Unpaid => "unpaid",
                GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Void => "void",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "draft" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Draft,
                "open" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Open,
                "paid" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Paid,
                "uncollectible" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Uncollectible,
                "unpaid" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Unpaid,
                "void" => GetSettingsBillingUsageResponsePeriodInvoiceVariant1Status.Void,
                _ => null,
            };
        }
    }
}