
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProviderStatus3
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
    public static class ResponseItemVariant2AvailableInferenceProviderProviderStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProviderStatus3 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProviderStatus3? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderProviderStatus3.Error,
                _ => null,
            };
        }
    }
}