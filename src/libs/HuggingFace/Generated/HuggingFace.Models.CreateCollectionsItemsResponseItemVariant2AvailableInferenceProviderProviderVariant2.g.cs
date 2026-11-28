
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Baseten,
        /// <summary>
        ///
        /// </summary>
        Cerebras,
        /// <summary>
        ///
        /// </summary>
        Cohere,
        /// <summary>
        ///
        /// </summary>
        Coreweave,
        /// <summary>
        ///
        /// </summary>
        Deepinfra,
        /// <summary>
        ///
        /// </summary>
        Deepseek,
        /// <summary>
        ///
        /// </summary>
        Digitalocean,
        /// <summary>
        ///
        /// </summary>
        Featherless,
        /// <summary>
        ///
        /// </summary>
        Fireworks,
        /// <summary>
        ///
        /// </summary>
        Liquid,
        /// <summary>
        ///
        /// </summary>
        Mistral,
        /// <summary>
        ///
        /// </summary>
        Moonshotai,
        /// <summary>
        ///
        /// </summary>
        Nebius,
        /// <summary>
        ///
        /// </summary>
        Novita,
        /// <summary>
        ///
        /// </summary>
        Parasail,
        /// <summary>
        ///
        /// </summary>
        Primeintellect,
        /// <summary>
        ///
        /// </summary>
        Reka,
        /// <summary>
        ///
        /// </summary>
        Tencent,
        /// <summary>
        ///
        /// </summary>
        Together,
        /// <summary>
        ///
        /// </summary>
        ZAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita => "novita",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka => "reka",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together => "together",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent,
                "together" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}