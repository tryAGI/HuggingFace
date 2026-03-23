
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Error => "error",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Live => "live",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Error,
                "live" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Live,
                "staging" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2.Staging,
                _ => null,
            };
        }
    }
}