
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.ExpiredChallenge => "EXPIRED_CHALLENGE",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.Pending => "PENDING",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.PendingChallenge => "PENDING_CHALLENGE",
                CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.ExpiredChallenge,
                "PENDING" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.Pending,
                "PENDING_CHALLENGE" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.PendingChallenge,
                "READY" => CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2.Ready,
                _ => null,
            };
        }
    }
}