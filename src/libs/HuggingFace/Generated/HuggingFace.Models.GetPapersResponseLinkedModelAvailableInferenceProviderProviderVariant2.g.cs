
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2
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
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Novita => "novita",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Reka => "reka",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Together => "together",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Tencent,
                "together" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}