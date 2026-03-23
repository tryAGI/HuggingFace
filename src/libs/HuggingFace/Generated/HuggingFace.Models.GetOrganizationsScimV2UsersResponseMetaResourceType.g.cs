
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimV2UsersResponseMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimV2UsersResponseMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimV2UsersResponseMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimV2UsersResponseMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimV2UsersResponseMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => GetOrganizationsScimV2UsersResponseMetaResourceType.User,
                _ => null,
            };
        }
    }
}