
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error => "error",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live => "live",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Error,
                "live" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Live,
                "staging" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus.Staging,
                _ => null,
            };
        }
    }
}