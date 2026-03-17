
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3RuntimeDomainStage
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
    public static class ResponseVariant1ItemItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3RuntimeDomainStage.Ready => "READY",
                ResponseVariant1ItemItemVariant3RuntimeDomainStage.Pending => "PENDING",
                ResponseVariant1ItemItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                ResponseVariant1ItemItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseVariant1ItemItemVariant3RuntimeDomainStage.Ready,
                "PENDING" => ResponseVariant1ItemItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => ResponseVariant1ItemItemVariant3RuntimeDomainStage.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseVariant1ItemItemVariant3RuntimeDomainStage.ExpiredChallenge,
                _ => null,
            };
        }
    }
}