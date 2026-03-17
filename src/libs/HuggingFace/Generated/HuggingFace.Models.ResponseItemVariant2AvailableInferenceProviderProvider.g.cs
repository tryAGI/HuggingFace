
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProvider
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
    public static class ResponseItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                ResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                ResponseItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                ResponseItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                ResponseItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                ResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                ResponseItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                ResponseItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                ResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                ResponseItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                ResponseItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                ResponseItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                ResponseItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                ResponseItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                ResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                ResponseItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                ResponseItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                ResponseItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                ResponseItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                ResponseItemVariant2AvailableInferenceProviderProvider.Together => "together",
                ResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                ResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => ResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => ResponseItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => ResponseItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => ResponseItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => ResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => ResponseItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => ResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => ResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => ResponseItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => ResponseItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => ResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => ResponseItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => ResponseItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => ResponseItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => ResponseItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => ResponseItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => ResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => ResponseItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => ResponseItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => ResponseItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => ResponseItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => ResponseItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => ResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => ResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}