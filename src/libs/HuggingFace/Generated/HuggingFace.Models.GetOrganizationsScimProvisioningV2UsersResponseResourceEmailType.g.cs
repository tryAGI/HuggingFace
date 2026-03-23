
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsScimProvisioningV2UsersResponseResourceEmailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType value)
        {
            return value switch
            {
                GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType? ToEnum(string value)
        {
            return value switch
            {
                "work" => GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType.Work,
                _ => null,
            };
        }
    }
}