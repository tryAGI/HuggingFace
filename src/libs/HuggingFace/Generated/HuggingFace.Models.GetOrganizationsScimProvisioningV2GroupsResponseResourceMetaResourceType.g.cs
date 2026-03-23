
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType.Group,
                _ => null,
            };
        }
    }
}