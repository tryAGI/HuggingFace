
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsScimProvisioningV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}