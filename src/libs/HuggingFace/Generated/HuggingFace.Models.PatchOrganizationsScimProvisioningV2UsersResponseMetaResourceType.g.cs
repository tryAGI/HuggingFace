
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}