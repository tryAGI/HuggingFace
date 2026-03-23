
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeDomainStage
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeDomainStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeDomainStage value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.ExpiredChallenge => "EXPIRED_CHALLENGE",
                PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.Pending => "PENDING",
                PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.PendingChallenge => "PENDING_CHALLENGE",
                PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeDomainStage? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED_CHALLENGE" => PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.ExpiredChallenge,
                "PENDING" => PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.Pending,
                "PENDING_CHALLENGE" => PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.PendingChallenge,
                "READY" => PatchCollectionsResponseDataItemVariant3RuntimeDomainStage.Ready,
                _ => null,
            };
        }
    }
}