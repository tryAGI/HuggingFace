
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimV2GroupsResponseResourceMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimV2GroupsResponseResourceMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimV2GroupsResponseResourceMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimV2GroupsResponseResourceMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimV2GroupsResponseResourceMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => GetOrganizationsScimV2GroupsResponseResourceMetaResourceType.Group,
                _ => null,
            };
        }
    }
}