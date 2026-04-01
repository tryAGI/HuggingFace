
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgenticProvisioningServicesResponseDataItemKycRequiredField
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
    public static class GetAgenticProvisioningServicesResponseDataItemKycRequiredFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgenticProvisioningServicesResponseDataItemKycRequiredField value)
        {
            return value switch
            {
                GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Country => "country",
                GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Email => "email",
                GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Name => "name",
                GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgenticProvisioningServicesResponseDataItemKycRequiredField? ToEnum(string value)
        {
            return value switch
            {
                "country" => GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Country,
                "email" => GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Email,
                "name" => GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Name,
                "phone" => GetAgenticProvisioningServicesResponseDataItemKycRequiredField.Phone,
                _ => null,
            };
        }
    }
}