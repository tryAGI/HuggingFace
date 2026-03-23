
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Error,
                "live" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}