
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita => "novita",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka => "reka",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together => "together",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Tencent,
                "together" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}