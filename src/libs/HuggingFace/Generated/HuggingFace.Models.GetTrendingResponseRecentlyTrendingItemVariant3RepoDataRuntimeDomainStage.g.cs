
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage
    {
        /// <summary>
        /// 
        /// </summary>
        ExpiredChallenge,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        PendingChallenge,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Pending => "PENDING",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.ExpiredChallenge,
                "PENDING" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.PendingChallenge,
                "READY" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}