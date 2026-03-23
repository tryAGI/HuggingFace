
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType.User,
                _ => null,
            };
        }
    }
}