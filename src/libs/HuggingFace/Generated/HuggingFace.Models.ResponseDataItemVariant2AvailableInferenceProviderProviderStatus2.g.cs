
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2 value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Live => "live",
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Staging => "staging",
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Live,
                "staging" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Staging,
                "error" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus2.Error,
                _ => null,
            };
        }
    }
}