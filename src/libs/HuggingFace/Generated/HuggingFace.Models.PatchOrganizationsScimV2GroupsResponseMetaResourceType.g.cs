
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsScimV2GroupsResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimV2GroupsResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimV2GroupsResponseMetaResourceType value)
        {
            return value switch
            {
                PatchOrganizationsScimV2GroupsResponseMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimV2GroupsResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => PatchOrganizationsScimV2GroupsResponseMetaResourceType.Group,
                _ => null,
            };
        }
    }
}