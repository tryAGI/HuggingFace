
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider
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
    public static class GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Together => "together",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}