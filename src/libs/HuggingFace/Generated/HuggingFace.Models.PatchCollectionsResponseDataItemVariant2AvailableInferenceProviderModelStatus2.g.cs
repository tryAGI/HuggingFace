
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Error => "error",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Live => "live",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Error,
                "live" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Live,
                "staging" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Staging,
                _ => null,
            };
        }
    }
}