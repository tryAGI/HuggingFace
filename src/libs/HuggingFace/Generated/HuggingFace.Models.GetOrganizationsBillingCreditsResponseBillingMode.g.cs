
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `prepaid` accounts can only use their credits, `postpaid` ones are billed for usage beyond them
    /// </summary>
    public enum GetOrganizationsBillingCreditsResponseBillingMode
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
    public static class GetOrganizationsBillingCreditsResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsBillingCreditsResponseBillingMode value)
        {
            return value switch
            {
                GetOrganizationsBillingCreditsResponseBillingMode.Postpaid => "postpaid",
                GetOrganizationsBillingCreditsResponseBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsBillingCreditsResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetOrganizationsBillingCreditsResponseBillingMode.Postpaid,
                "prepaid" => GetOrganizationsBillingCreditsResponseBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}