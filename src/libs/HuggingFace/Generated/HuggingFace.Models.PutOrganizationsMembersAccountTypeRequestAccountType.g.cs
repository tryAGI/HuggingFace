
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutOrganizationsMembersAccountTypeRequestAccountType
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationsMembersAccountTypeRequestAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsMembersAccountTypeRequestAccountType value)
        {
            return value switch
            {
                PutOrganizationsMembersAccountTypeRequestAccountType.External => "external",
                PutOrganizationsMembersAccountTypeRequestAccountType.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsMembersAccountTypeRequestAccountType? ToEnum(string value)
        {
            return value switch
            {
                "external" => PutOrganizationsMembersAccountTypeRequestAccountType.External,
                "member" => PutOrganizationsMembersAccountTypeRequestAccountType.Member,
                _ => null,
            };
        }
    }
}