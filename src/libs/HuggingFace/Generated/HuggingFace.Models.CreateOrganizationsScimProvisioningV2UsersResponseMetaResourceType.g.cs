
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}