
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Error => "error",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Live => "live",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Error,
                "live" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Live,
                "staging" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus.Staging,
                _ => null,
            };
        }
    }
}