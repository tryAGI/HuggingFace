
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderModelStatus
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Staging,
                "error" => ResponseDataItemVariant2AvailableInferenceProviderModelStatus.Error,
                _ => null,
            };
        }
    }
}