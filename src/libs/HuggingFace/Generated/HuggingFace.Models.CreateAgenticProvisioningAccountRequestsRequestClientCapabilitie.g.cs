
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgenticProvisioningAccountRequestsRequestClientCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie value)
        {
            return value switch
            {
                CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Browser => "browser",
                CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Email => "email",
                CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "browser" => CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Browser,
                "email" => CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Email,
                "sms" => CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie.Sms,
                _ => null,
            };
        }
    }
}