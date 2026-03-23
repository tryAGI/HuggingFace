
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseOrgBillingMode
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
    public static class GetWhoamiV2ResponseOrgBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseOrgBillingMode value)
        {
            return value switch
            {
                GetWhoamiV2ResponseOrgBillingMode.Postpaid => "postpaid",
                GetWhoamiV2ResponseOrgBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseOrgBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetWhoamiV2ResponseOrgBillingMode.Postpaid,
                "prepaid" => GetWhoamiV2ResponseOrgBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}