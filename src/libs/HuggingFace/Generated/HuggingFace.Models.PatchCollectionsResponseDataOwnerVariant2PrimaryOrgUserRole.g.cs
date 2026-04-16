
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole
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
    public static class PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Read => "read",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Read,
                "write" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}