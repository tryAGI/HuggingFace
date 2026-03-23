
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Error => "error",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Live => "live",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Error,
                "live" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Live,
                "staging" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging,
                _ => null,
            };
        }
    }
}