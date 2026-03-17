
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                "error" => ResponseDataItemVariant2AvailableInferenceProviderProviderStatus.Error,
                _ => null,
            };
        }
    }
}