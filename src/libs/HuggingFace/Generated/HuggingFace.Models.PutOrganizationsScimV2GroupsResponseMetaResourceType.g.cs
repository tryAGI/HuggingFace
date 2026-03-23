
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsScimV2GroupsResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsScimV2GroupsResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsScimV2GroupsResponseMetaResourceType value)
        {
            return value switch
            {
                PutOrganizationsScimV2GroupsResponseMetaResourceType.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsScimV2GroupsResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "Group" => PutOrganizationsScimV2GroupsResponseMetaResourceType.Group,
                _ => null,
            };
        }
    }
}