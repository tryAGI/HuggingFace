
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole
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
    public static class GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Read => "read",
                GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Read,
                "write" => GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}