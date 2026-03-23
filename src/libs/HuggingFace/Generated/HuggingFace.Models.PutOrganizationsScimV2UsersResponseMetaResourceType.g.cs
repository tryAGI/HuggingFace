
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsScimV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsScimV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsScimV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                PutOrganizationsScimV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsScimV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => PutOrganizationsScimV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}