
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus
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
    public static class GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Error,
                "live" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}