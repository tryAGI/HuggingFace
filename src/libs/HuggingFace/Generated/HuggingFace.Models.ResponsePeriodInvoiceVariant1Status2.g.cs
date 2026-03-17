
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodInvoiceVariant1Status2
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
    public static class ResponsePeriodInvoiceVariant1Status2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodInvoiceVariant1Status2 value)
        {
            return value switch
            {
                ResponsePeriodInvoiceVariant1Status2.Draft => "draft",
                ResponsePeriodInvoiceVariant1Status2.Open => "open",
                ResponsePeriodInvoiceVariant1Status2.Paid => "paid",
                ResponsePeriodInvoiceVariant1Status2.Uncollectible => "uncollectible",
                ResponsePeriodInvoiceVariant1Status2.Void => "void",
                ResponsePeriodInvoiceVariant1Status2.Unpaid => "unpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodInvoiceVariant1Status2? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponsePeriodInvoiceVariant1Status2.Draft,
                "open" => ResponsePeriodInvoiceVariant1Status2.Open,
                "paid" => ResponsePeriodInvoiceVariant1Status2.Paid,
                "uncollectible" => ResponsePeriodInvoiceVariant1Status2.Uncollectible,
                "void" => ResponsePeriodInvoiceVariant1Status2.Void,
                "unpaid" => ResponsePeriodInvoiceVariant1Status2.Unpaid,
                _ => null,
            };
        }
    }
}