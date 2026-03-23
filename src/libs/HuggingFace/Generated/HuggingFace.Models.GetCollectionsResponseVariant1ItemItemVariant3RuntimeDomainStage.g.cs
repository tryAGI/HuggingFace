
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage
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
    public static class GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.Pending => "PENDING",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.ExpiredChallenge,
                "PENDING" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.PendingChallenge,
                "READY" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}