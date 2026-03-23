
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}