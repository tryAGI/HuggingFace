
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus
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
    public static class ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "live" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Staging,
                "error" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus.Error,
                _ => null,
            };
        }
    }
}