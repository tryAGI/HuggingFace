
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole
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
    public static class GetCollectionsResponseOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Read => "read",
                GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Read,
                "write" => GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}