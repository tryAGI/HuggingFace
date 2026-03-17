
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderModelStatus5
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
    public static class ResponseItemVariant2AvailableInferenceProviderModelStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderModelStatus5 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderModelStatus5.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderModelStatus5.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderModelStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderModelStatus5? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderModelStatus5.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderModelStatus5.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderModelStatus5.Error,
                _ => null,
            };
        }
    }
}