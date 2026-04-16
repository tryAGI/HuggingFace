
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                "write" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}