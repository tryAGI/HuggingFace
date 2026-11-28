
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita => "novita",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka => "reka",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together => "together",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent,
                "together" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}