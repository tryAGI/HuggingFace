
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType value)
        {
            return value switch
            {
                PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType.Group,
                _ => null,
            };
        }
    }
}