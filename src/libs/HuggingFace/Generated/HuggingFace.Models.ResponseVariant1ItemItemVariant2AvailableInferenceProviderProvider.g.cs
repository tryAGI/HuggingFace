
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider
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
    public static class ResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Together => "together",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => ResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}