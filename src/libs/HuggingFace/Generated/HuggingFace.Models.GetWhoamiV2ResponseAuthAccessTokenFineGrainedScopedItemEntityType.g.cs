
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType
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
    public static class GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType value)
        {
            return value switch
            {
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Bucket => "bucket",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Collection => "collection",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Dataset => "dataset",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Kernel => "kernel",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Model => "model",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.OauthApp => "oauth-app",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Org => "org",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.ResourceGroup => "resource-group",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Space => "space",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Bucket,
                "collection" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Collection,
                "dataset" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Dataset,
                "kernel" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Kernel,
                "model" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Model,
                "oauth-app" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.OauthApp,
                "org" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Org,
                "resource-group" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.ResourceGroup,
                "space" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Space,
                "user" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType.User,
                _ => null,
            };
        }
    }
}