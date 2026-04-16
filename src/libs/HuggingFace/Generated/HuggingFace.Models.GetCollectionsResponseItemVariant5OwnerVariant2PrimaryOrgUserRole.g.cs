
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                "write" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}