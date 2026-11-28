
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1
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
        Deepinfra,
        /// <summary>
        ///
        /// </summary>
        FalAi,
        /// <summary>
        ///
        /// </summary>
        FeatherlessAi,
        /// <summary>
        ///
        /// </summary>
        FireworksAi,
        /// <summary>
        ///
        /// </summary>
        Groq,
        /// <summary>
        ///
        /// </summary>
        HfInference,
        /// <summary>
        ///
        /// </summary>
        Novita,
        /// <summary>
        ///
        /// </summary>
        Nscale,
        /// <summary>
        ///
        /// </summary>
        Openrouter,
        /// <summary>
        ///
        /// </summary>
        Ovhcloud,
        /// <summary>
        ///
        /// </summary>
        Publicai,
        /// <summary>
        ///
        /// </summary>
        Replicate,
        /// <summary>
        ///
        /// </summary>
        Scaleway,
        /// <summary>
        ///
        /// </summary>
        Together,
        /// <summary>
        ///
        /// </summary>
        Wavespeed,
        /// <summary>
        ///
        /// </summary>
        ZaiOrg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Groq => "groq",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Novita => "novita",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Together => "together",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => GetPapersResponseLinkedModelAvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}