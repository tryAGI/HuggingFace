
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAvailableInferenceProviderProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabs,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Clarifai,
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
        Hyperbolic,
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
        Nscale,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        Openai,
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
        Sambanova,
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
    public static class GetPapersResponseLinkedModelAvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAvailableInferenceProviderProvider value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Baseten => "baseten",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Cerebras => "cerebras",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Clarifai => "clarifai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Cohere => "cohere",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FalAi => "fal-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Groq => "groq",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.HfInference => "hf-inference",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nebius => "nebius",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Novita => "novita",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nscale => "nscale",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nvidia => "nvidia",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Openai => "openai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Publicai => "publicai",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Replicate => "replicate",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Sambanova => "sambanova",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Scaleway => "scaleway",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Together => "together",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                GetPapersResponseLinkedModelAvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Cerebras,
                "clarifai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Clarifai,
                "cohere" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Cohere,
                "deepinfra" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.FireworksAi,
                "groq" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Groq,
                "hf-inference" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nebius,
                "novita" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Novita,
                "nscale" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nscale,
                "nvidia" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Nvidia,
                "openai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Openai,
                "ovhcloud" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Publicai,
                "replicate" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Replicate,
                "sambanova" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Sambanova,
                "scaleway" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Scaleway,
                "together" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Together,
                "wavespeed" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => GetPapersResponseLinkedModelAvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}