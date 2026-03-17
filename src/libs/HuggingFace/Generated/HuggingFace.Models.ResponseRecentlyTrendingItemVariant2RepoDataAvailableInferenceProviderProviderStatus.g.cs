
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus
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
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Live => "live",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Staging => "staging",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Live,
                "staging" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Staging,
                "error" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus.Error,
                _ => null,
            };
        }
    }
}