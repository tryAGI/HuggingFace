
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        Staging,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Live => "live",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Staging => "staging",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Live,
                "staging" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Staging,
                "error" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus.Error,
                _ => null,
            };
        }
    }
}