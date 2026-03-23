
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Error,
                "live" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}