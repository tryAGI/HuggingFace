
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Error => "error",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Live => "live",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Error,
                "live" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Live,
                "staging" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2.Staging,
                _ => null,
            };
        }
    }
}