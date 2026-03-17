
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3RuntimeDomainStage
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
    public static class ResponseDataItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                ResponseDataItemVariant3RuntimeDomainStage.Ready => "READY",
                ResponseDataItemVariant3RuntimeDomainStage.Pending => "PENDING",
                ResponseDataItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                ResponseDataItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseDataItemVariant3RuntimeDomainStage.Ready,
                "PENDING" => ResponseDataItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => ResponseDataItemVariant3RuntimeDomainStage.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseDataItemVariant3RuntimeDomainStage.ExpiredChallenge,
                _ => null,
            };
        }
    }
}