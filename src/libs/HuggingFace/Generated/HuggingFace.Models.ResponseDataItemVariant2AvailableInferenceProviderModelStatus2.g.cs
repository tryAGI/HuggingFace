
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderModelStatus2
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderModelStatus2 value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Live => "live",
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Staging => "staging",
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Live,
                "staging" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Staging,
                "error" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus2.Error,
                _ => null,
            };
        }
    }
}