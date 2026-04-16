
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole
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
    public static class PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}