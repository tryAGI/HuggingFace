
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeDomainStage
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
    public static class GetCollectionsResponseItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                GetCollectionsResponseItemVariant3RuntimeDomainStage.Pending => "PENDING",
                GetCollectionsResponseItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                GetCollectionsResponseItemVariant3RuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => GetCollectionsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge,
                "PENDING" => GetCollectionsResponseItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => GetCollectionsResponseItemVariant3RuntimeDomainStage.PendingChallenge,
                "READY" => GetCollectionsResponseItemVariant3RuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}