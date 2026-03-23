
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Error,
                "live" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}