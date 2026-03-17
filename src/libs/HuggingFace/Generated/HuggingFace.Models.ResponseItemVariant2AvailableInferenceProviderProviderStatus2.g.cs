
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProviderStatus2
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
    public static class ResponseItemVariant2AvailableInferenceProviderProviderStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProviderStatus2 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProviderStatus2? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderProviderStatus2.Error,
                _ => null,
            };
        }
    }
}