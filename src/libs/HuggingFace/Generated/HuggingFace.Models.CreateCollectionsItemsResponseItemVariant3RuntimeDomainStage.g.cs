
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.Pending => "PENDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.ExpiredChallenge,
                "PENDING" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.PendingChallenge,
                "READY" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}