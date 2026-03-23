
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole
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
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}