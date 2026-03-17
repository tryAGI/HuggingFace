
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProvider3
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
    public static class ResponseItemVariant2AvailableInferenceProviderProvider3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProvider3 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProvider3.Baseten => "baseten",
                ResponseItemVariant2AvailableInferenceProviderProvider3.BlackForestLabs => "black-forest-labs",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Cerebras => "cerebras",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Clarifai => "clarifai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Cohere => "cohere",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Deepinfra => "deepinfra",
                ResponseItemVariant2AvailableInferenceProviderProvider3.FalAi => "fal-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.FeatherlessAi => "featherless-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.FireworksAi => "fireworks-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Groq => "groq",
                ResponseItemVariant2AvailableInferenceProviderProvider3.HfInference => "hf-inference",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Hyperbolic => "hyperbolic",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Nebius => "nebius",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Novita => "novita",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Nscale => "nscale",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Nvidia => "nvidia",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Openai => "openai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Ovhcloud => "ovhcloud",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Publicai => "publicai",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Replicate => "replicate",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Sambanova => "sambanova",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Scaleway => "scaleway",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Together => "together",
                ResponseItemVariant2AvailableInferenceProviderProvider3.Wavespeed => "wavespeed",
                ResponseItemVariant2AvailableInferenceProviderProvider3.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProvider3? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseItemVariant2AvailableInferenceProviderProvider3.Baseten,
                "black-forest-labs" => ResponseItemVariant2AvailableInferenceProviderProvider3.BlackForestLabs,
                "cerebras" => ResponseItemVariant2AvailableInferenceProviderProvider3.Cerebras,
                "clarifai" => ResponseItemVariant2AvailableInferenceProviderProvider3.Clarifai,
                "cohere" => ResponseItemVariant2AvailableInferenceProviderProvider3.Cohere,
                "deepinfra" => ResponseItemVariant2AvailableInferenceProviderProvider3.Deepinfra,
                "fal-ai" => ResponseItemVariant2AvailableInferenceProviderProvider3.FalAi,
                "featherless-ai" => ResponseItemVariant2AvailableInferenceProviderProvider3.FeatherlessAi,
                "fireworks-ai" => ResponseItemVariant2AvailableInferenceProviderProvider3.FireworksAi,
                "groq" => ResponseItemVariant2AvailableInferenceProviderProvider3.Groq,
                "hf-inference" => ResponseItemVariant2AvailableInferenceProviderProvider3.HfInference,
                "hyperbolic" => ResponseItemVariant2AvailableInferenceProviderProvider3.Hyperbolic,
                "nebius" => ResponseItemVariant2AvailableInferenceProviderProvider3.Nebius,
                "novita" => ResponseItemVariant2AvailableInferenceProviderProvider3.Novita,
                "nscale" => ResponseItemVariant2AvailableInferenceProviderProvider3.Nscale,
                "nvidia" => ResponseItemVariant2AvailableInferenceProviderProvider3.Nvidia,
                "openai" => ResponseItemVariant2AvailableInferenceProviderProvider3.Openai,
                "ovhcloud" => ResponseItemVariant2AvailableInferenceProviderProvider3.Ovhcloud,
                "publicai" => ResponseItemVariant2AvailableInferenceProviderProvider3.Publicai,
                "replicate" => ResponseItemVariant2AvailableInferenceProviderProvider3.Replicate,
                "sambanova" => ResponseItemVariant2AvailableInferenceProviderProvider3.Sambanova,
                "scaleway" => ResponseItemVariant2AvailableInferenceProviderProvider3.Scaleway,
                "together" => ResponseItemVariant2AvailableInferenceProviderProvider3.Together,
                "wavespeed" => ResponseItemVariant2AvailableInferenceProviderProvider3.Wavespeed,
                "zai-org" => ResponseItemVariant2AvailableInferenceProviderProvider3.ZaiOrg,
                _ => null,
            };
        }
    }
}