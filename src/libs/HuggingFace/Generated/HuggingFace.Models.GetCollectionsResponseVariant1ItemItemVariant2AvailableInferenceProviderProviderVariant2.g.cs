
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2
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
    public static class GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Novita => "novita",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Reka => "reka",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Together => "together",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Tencent,
                "together" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}