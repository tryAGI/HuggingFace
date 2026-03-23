
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Error,
                "live" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}