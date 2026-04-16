
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2
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
    public static class GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read => "read",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read,
                "write" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}