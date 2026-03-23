
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status
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
    public static class GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status value)
        {
            return value switch
            {
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Draft => "draft",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Open => "open",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Paid => "paid",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Uncollectible => "uncollectible",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Unpaid => "unpaid",
                GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Void => "void",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "draft" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Draft,
                "open" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Open,
                "paid" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Paid,
                "uncollectible" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Uncollectible,
                "unpaid" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Unpaid,
                "void" => GetOrganizationsBillingUsageResponsePeriodInvoiceVariant1Status.Void,
                _ => null,
            };
        }
    }
}