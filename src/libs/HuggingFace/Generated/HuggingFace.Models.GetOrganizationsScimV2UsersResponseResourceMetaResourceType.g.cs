
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsScimV2UsersResponseResourceMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimV2UsersResponseResourceMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimV2UsersResponseResourceMetaResourceType value)
        {
            return value switch
            {
                GetOrganizationsScimV2UsersResponseResourceMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimV2UsersResponseResourceMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => GetOrganizationsScimV2UsersResponseResourceMetaResourceType.User,
                _ => null,
            };
        }
    }
}