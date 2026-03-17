
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class ResponseItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderProviderStatus.Error,
                _ => null,
            };
        }
    }
}