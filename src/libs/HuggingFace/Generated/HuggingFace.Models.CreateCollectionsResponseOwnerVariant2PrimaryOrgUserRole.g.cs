
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}