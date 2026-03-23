
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error,
                "live" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}