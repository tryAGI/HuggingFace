
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType value)
        {
            return value switch
            {
                PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType.Group,
                _ => null,
            };
        }
    }
}