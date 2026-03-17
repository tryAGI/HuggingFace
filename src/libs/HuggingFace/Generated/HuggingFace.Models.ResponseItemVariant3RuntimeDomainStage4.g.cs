
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeDomainStage4
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
    public static class ResponseItemVariant3RuntimeDomainStage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeDomainStage4 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeDomainStage4.Ready => "READY",
                ResponseItemVariant3RuntimeDomainStage4.Pending => "PENDING",
                ResponseItemVariant3RuntimeDomainStage4.PendingChallenge => "PENDING_CHALLENGE",
                ResponseItemVariant3RuntimeDomainStage4.ExpiredChallenge => "EXPIRED_CHALLENGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeDomainStage4? ToEnum(string value)
        {
            return value switch
            {
                "READY" => ResponseItemVariant3RuntimeDomainStage4.Ready,
                "PENDING" => ResponseItemVariant3RuntimeDomainStage4.Pending,
                "PENDING_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage4.PendingChallenge,
                "EXPIRED_CHALLENGE" => ResponseItemVariant3RuntimeDomainStage4.ExpiredChallenge,
                _ => null,
            };
        }
    }
}