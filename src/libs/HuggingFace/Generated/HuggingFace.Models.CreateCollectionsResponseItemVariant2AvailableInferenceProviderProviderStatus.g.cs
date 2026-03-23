
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error,
                "live" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}