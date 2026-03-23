
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Baseten => "baseten",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs => "black-forest-labs",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras => "cerebras",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai => "clarifai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Cohere => "cohere",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra => "deepinfra",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FalAi => "fal-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi => "featherless-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi => "fireworks-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Groq => "groq",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.HfInference => "hf-inference",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic => "hyperbolic",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nebius => "nebius",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Novita => "novita",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nscale => "nscale",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia => "nvidia",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Openai => "openai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud => "ovhcloud",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Publicai => "publicai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Replicate => "replicate",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova => "sambanova",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway => "scaleway",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Together => "together",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed => "wavespeed",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Baseten,
                "black-forest-labs" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs,
                "cerebras" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras,
                "clarifai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai,
                "cohere" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Cohere,
                "deepinfra" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra,
                "fal-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FalAi,
                "featherless-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi,
                "fireworks-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi,
                "groq" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Groq,
                "hf-inference" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.HfInference,
                "hyperbolic" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic,
                "nebius" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nebius,
                "novita" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Novita,
                "nscale" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nscale,
                "nvidia" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia,
                "openai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Openai,
                "ovhcloud" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud,
                "publicai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Publicai,
                "replicate" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Replicate,
                "sambanova" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova,
                "scaleway" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway,
                "together" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Together,
                "wavespeed" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed,
                "zai-org" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg,
                _ => null,
            };
        }
    }
}