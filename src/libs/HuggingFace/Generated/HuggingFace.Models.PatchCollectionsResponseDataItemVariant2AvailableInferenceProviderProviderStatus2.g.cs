
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Error => "error",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Live => "live",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Error,
                "live" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Live,
                "staging" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Staging,
                _ => null,
            };
        }
    }
}