
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus
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
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Error => "error",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Live => "live",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Error,
                "live" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Live,
                "staging" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}