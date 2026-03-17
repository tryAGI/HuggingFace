
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderModelStatus
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
    public static class ResponseItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                ResponseItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                ResponseItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => ResponseItemVariant2AvailableInferenceProviderModelStatus.Staging,
                "error" => ResponseItemVariant2AvailableInferenceProviderModelStatus.Error,
                _ => null,
            };
        }
    }
}