
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Error,
                "live" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}