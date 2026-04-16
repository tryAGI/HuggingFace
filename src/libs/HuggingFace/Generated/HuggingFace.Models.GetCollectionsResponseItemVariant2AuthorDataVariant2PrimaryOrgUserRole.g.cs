
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole
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
    public static class GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}