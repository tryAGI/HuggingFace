
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Error => "error",
                GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Live => "live",
                GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Error,
                "live" => GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Live,
                "staging" => GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}