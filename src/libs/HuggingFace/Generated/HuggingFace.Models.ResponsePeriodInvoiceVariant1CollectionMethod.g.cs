
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodInvoiceVariant1CollectionMethod
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
    public static class ResponsePeriodInvoiceVariant1CollectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodInvoiceVariant1CollectionMethod value)
        {
            return value switch
            {
                ResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically => "charge_automatically",
                ResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice => "send_invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodInvoiceVariant1CollectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "charge_automatically" => ResponsePeriodInvoiceVariant1CollectionMethod.ChargeAutomatically,
                "send_invoice" => ResponsePeriodInvoiceVariant1CollectionMethod.SendInvoice,
                _ => null,
            };
        }
    }
}