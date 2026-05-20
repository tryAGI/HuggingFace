
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        NoAccess,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}