
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum PutOrganizationsScimProvisioningV2UsersResponseEmailType
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsScimProvisioningV2UsersResponseEmailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsScimProvisioningV2UsersResponseEmailType value)
        {
            return value switch
            {
                PutOrganizationsScimProvisioningV2UsersResponseEmailType.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsScimProvisioningV2UsersResponseEmailType? ToEnum(string value)
        {
            return value switch
            {
                "work" => PutOrganizationsScimProvisioningV2UsersResponseEmailType.Work,
                _ => null,
            };
        }
    }
}