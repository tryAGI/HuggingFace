
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodInvoiceVariant1Status
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
        Void,
        /// <summary>
        /// 
        /// </summary>
        Unpaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsePeriodInvoiceVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodInvoiceVariant1Status value)
        {
            return value switch
            {
                ResponsePeriodInvoiceVariant1Status.Draft => "draft",
                ResponsePeriodInvoiceVariant1Status.Open => "open",
                ResponsePeriodInvoiceVariant1Status.Paid => "paid",
                ResponsePeriodInvoiceVariant1Status.Uncollectible => "uncollectible",
                ResponsePeriodInvoiceVariant1Status.Void => "void",
                ResponsePeriodInvoiceVariant1Status.Unpaid => "unpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodInvoiceVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponsePeriodInvoiceVariant1Status.Draft,
                "open" => ResponsePeriodInvoiceVariant1Status.Open,
                "paid" => ResponsePeriodInvoiceVariant1Status.Paid,
                "uncollectible" => ResponsePeriodInvoiceVariant1Status.Uncollectible,
                "void" => ResponsePeriodInvoiceVariant1Status.Void,
                "unpaid" => ResponsePeriodInvoiceVariant1Status.Unpaid,
                _ => null,
            };
        }
    }
}