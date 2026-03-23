
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimProvisioningV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}