
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseBillingMode
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
    public static class GetWhoamiV2ResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseBillingMode value)
        {
            return value switch
            {
                GetWhoamiV2ResponseBillingMode.Postpaid => "postpaid",
                GetWhoamiV2ResponseBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetWhoamiV2ResponseBillingMode.Postpaid,
                "prepaid" => GetWhoamiV2ResponseBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}