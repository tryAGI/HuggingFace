
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodInvoiceVariant1CollectionMethod2
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
    public static class ResponsePeriodInvoiceVariant1CollectionMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodInvoiceVariant1CollectionMethod2 value)
        {
            return value switch
            {
                ResponsePeriodInvoiceVariant1CollectionMethod2.ChargeAutomatically => "charge_automatically",
                ResponsePeriodInvoiceVariant1CollectionMethod2.SendInvoice => "send_invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodInvoiceVariant1CollectionMethod2? ToEnum(string value)
        {
            return value switch
            {
                "charge_automatically" => ResponsePeriodInvoiceVariant1CollectionMethod2.ChargeAutomatically,
                "send_invoice" => ResponsePeriodInvoiceVariant1CollectionMethod2.SendInvoice,
                _ => null,
            };
        }
    }
}