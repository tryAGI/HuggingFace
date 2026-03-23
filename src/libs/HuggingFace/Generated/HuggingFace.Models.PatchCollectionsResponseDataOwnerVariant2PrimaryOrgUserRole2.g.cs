
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2
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
    public static class PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Read => "read",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Contributor,
                "read" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Read,
                "write" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}