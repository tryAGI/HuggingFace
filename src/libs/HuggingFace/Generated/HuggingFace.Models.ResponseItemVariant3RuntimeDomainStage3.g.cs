
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeDomainStage3
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
    public static class ResponseItemVariant3RuntimeDomainStage3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeDomainStage3 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeDomainStage3.Ready => "READY",
                ResponseItemVariant3RuntimeDomainStage3.Pending => "PENDING",
                ResponseItemVariant3RuntimeDomainStage3.PendingChallenge => "PENDING_CHALLENGE",
                ResponseItemVariant3RuntimeDomainStage3.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeDomainStage3? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseItemVariant3RuntimeDomainStage3.Ready,
                "PENDING" => ResponseItemVariant3RuntimeDomainStage3.Pending,
                "PENDING_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage3.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage3.ExpiredChallenge,
                _ => null,
            };
        }
    }
}