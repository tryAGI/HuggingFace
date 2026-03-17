
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage
    {
        /// <summary>
        /// 
        /// </summary>
        Ready,
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
        ExpiredChallenge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Ready => "READY",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Pending => "PENDING",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Ready,
                "PENDING" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage.ExpiredChallenge,
                _ => null,
            };
        }
    }
}