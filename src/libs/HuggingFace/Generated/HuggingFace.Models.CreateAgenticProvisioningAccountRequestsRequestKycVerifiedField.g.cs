
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField
    {
        /// <summary>
        /// 
        /// </summary>
        Country,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgenticProvisioningAccountRequestsRequestKycVerifiedFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField value)
        {
            return value switch
            {
                CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Country => "country",
                CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Email => "email",
                CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Name => "name",
                CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField? ToEnum(string value)
        {
            return value switch
            {
                "country" => CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Country,
                "email" => CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Email,
                "name" => CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Name,
                "phone" => CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField.Phone,
                _ => null,
            };
        }
    }
}