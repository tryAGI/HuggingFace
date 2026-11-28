
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `prepaid` accounts can only use their credits, `postpaid` ones are billed for usage beyond them
    /// </summary>
    public enum GetSettingsBillingCreditsResponseBillingMode
    {
        /// <summary>
        ///
        /// </summary>
        Postpaid,
        /// <summary>
        ///
        /// </summary>
        Prepaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsBillingCreditsResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsBillingCreditsResponseBillingMode value)
        {
            return value switch
            {
                GetSettingsBillingCreditsResponseBillingMode.Postpaid => "postpaid",
                GetSettingsBillingCreditsResponseBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsBillingCreditsResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetSettingsBillingCreditsResponseBillingMode.Postpaid,
                "prepaid" => GetSettingsBillingCreditsResponseBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}