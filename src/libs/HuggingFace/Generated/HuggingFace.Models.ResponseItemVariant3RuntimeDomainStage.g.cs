
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeDomainStage
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
    public static class ResponseItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeDomainStage.Ready => "READY",
                ResponseItemVariant3RuntimeDomainStage.Pending => "PENDING",
                ResponseItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                ResponseItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseItemVariant3RuntimeDomainStage.Ready,
                "PENDING" => ResponseItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage.ExpiredChallenge,
                _ => null,
            };
        }
    }
}