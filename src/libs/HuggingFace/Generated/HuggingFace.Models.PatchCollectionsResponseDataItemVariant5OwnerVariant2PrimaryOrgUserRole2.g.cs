
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2
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
    public static class PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read => "read",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read,
                "write" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}