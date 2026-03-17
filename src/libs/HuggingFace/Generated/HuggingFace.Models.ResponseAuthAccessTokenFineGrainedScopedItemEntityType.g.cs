
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthAccessTokenFineGrainedScopedItemEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroup,
        /// <summary>
        /// 
        /// </summary>
        OauthApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAuthAccessTokenFineGrainedScopedItemEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthAccessTokenFineGrainedScopedItemEntityType value)
        {
            return value switch
            {
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Dataset => "dataset",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Model => "model",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Space => "space",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Bucket => "bucket",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Kernel => "kernel",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Collection => "collection",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Org => "org",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.User => "user",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.ResourceGroup => "resource-group",
                ResponseAuthAccessTokenFineGrainedScopedItemEntityType.OauthApp => "oauth-app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthAccessTokenFineGrainedScopedItemEntityType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Dataset,
                "model" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Model,
                "space" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Space,
                "bucket" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Bucket,
                "kernel" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Kernel,
                "collection" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Collection,
                "org" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.Org,
                "user" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.User,
                "resource-group" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.ResourceGroup,
                "oauth-app" => ResponseAuthAccessTokenFineGrainedScopedItemEntityType.OauthApp,
                _ => null,
            };
        }
    }
}