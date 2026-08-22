
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        OauthApp,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroup,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType value)
        {
            return value switch
            {
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Bucket => "bucket",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Collection => "collection",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Dataset => "dataset",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Kernel => "kernel",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Model => "model",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.OauthApp => "oauth-app",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Org => "org",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.ResourceGroup => "resource-group",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Space => "space",
                GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Bucket,
                "collection" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Collection,
                "dataset" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Dataset,
                "kernel" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Kernel,
                "model" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Model,
                "oauth-app" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.OauthApp,
                "org" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Org,
                "resource-group" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.ResourceGroup,
                "space" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.Space,
                "user" => GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType.User,
                _ => null,
            };
        }
    }
}