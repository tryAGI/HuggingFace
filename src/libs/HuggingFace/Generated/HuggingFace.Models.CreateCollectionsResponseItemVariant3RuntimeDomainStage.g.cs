
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3RuntimeDomainStage
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
    public static class CreateCollectionsResponseItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                CreateCollectionsResponseItemVariant3RuntimeDomainStage.Pending => "PENDING",
                CreateCollectionsResponseItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                CreateCollectionsResponseItemVariant3RuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => CreateCollectionsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge,
                "PENDING" => CreateCollectionsResponseItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => CreateCollectionsResponseItemVariant3RuntimeDomainStage.PendingChallenge,
                "READY" => CreateCollectionsResponseItemVariant3RuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}