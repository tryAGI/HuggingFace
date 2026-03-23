
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum PatchOrganizationsScimV2UsersResponseEmailType
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimV2UsersResponseEmailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimV2UsersResponseEmailType value)
        {
            return value switch
            {
                PatchOrganizationsScimV2UsersResponseEmailType.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimV2UsersResponseEmailType? ToEnum(string value)
        {
            return value switch
            {
                "work" => PatchOrganizationsScimV2UsersResponseEmailType.Work,
                _ => null,
            };
        }
    }
}