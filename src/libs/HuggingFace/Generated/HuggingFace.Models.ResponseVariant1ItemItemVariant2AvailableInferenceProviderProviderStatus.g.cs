
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        Staging,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                "error" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus.Error,
                _ => null,
            };
        }
    }
}