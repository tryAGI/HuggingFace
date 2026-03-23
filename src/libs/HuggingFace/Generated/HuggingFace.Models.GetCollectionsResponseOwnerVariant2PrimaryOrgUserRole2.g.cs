
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2
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
    public static class GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Read => "read",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Contributor,
                "read" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Read,
                "write" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}