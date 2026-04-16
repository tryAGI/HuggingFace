
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                "write" => GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}