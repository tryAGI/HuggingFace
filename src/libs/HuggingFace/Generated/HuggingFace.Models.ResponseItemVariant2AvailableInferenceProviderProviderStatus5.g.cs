
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProviderStatus5
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
    public static class ResponseItemVariant2AvailableInferenceProviderProviderStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProviderStatus5 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProviderStatus5? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderProviderStatus5.Error,
                _ => null,
            };
        }
    }
}