
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Novita => "novita",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Reka => "reka",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Together => "together",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Tencent,
                "together" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}