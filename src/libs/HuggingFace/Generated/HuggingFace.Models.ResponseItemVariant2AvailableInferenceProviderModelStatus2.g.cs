
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderModelStatus2
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
    public static class ResponseItemVariant2AvailableInferenceProviderModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderModelStatus2 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderModelStatus2.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderModelStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderModelStatus2.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderModelStatus2.Error,
                _ => null,
            };
        }
    }
}