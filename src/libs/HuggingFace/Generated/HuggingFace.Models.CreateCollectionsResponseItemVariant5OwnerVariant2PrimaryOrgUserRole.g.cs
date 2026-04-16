
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}