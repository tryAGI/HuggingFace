
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProvider4
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
    public static class ResponseItemVariant2AvailableInferenceProviderProvider4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProvider4 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProvider4.Baseten => "baseten",
                ResponseItemVariant2AvailableInferenceProviderProvider4.BlackForestLabs => "black-forest-labs",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Cerebras => "cerebras",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Clarifai => "clarifai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Cohere => "cohere",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Deepinfra => "deepinfra",
                ResponseItemVariant2AvailableInferenceProviderProvider4.FalAi => "fal-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.FeatherlessAi => "featherless-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.FireworksAi => "fireworks-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Groq => "groq",
                ResponseItemVariant2AvailableInferenceProviderProvider4.HfInference => "hf-inference",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Hyperbolic => "hyperbolic",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Nebius => "nebius",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Novita => "novita",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Nscale => "nscale",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Nvidia => "nvidia",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Openai => "openai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Ovhcloud => "ovhcloud",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Publicai => "publicai",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Replicate => "replicate",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Sambanova => "sambanova",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Scaleway => "scaleway",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Together => "together",
                ResponseItemVariant2AvailableInferenceProviderProvider4.Wavespeed => "wavespeed",
                ResponseItemVariant2AvailableInferenceProviderProvider4.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProvider4? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseItemVariant2AvailableInferenceProviderProvider4.Baseten,
                "black-forest-labs" => ResponseItemVariant2AvailableInferenceProviderProvider4.BlackForestLabs,
                "cerebras" => ResponseItemVariant2AvailableInferenceProviderProvider4.Cerebras,
                "clarifai" => ResponseItemVariant2AvailableInferenceProviderProvider4.Clarifai,
                "cohere" => ResponseItemVariant2AvailableInferenceProviderProvider4.Cohere,
                "deepinfra" => ResponseItemVariant2AvailableInferenceProviderProvider4.Deepinfra,
                "fal-ai" => ResponseItemVariant2AvailableInferenceProviderProvider4.FalAi,
                "featherless-ai" => ResponseItemVariant2AvailableInferenceProviderProvider4.FeatherlessAi,
                "fireworks-ai" => ResponseItemVariant2AvailableInferenceProviderProvider4.FireworksAi,
                "groq" => ResponseItemVariant2AvailableInferenceProviderProvider4.Groq,
                "hf-inference" => ResponseItemVariant2AvailableInferenceProviderProvider4.HfInference,
                "hyperbolic" => ResponseItemVariant2AvailableInferenceProviderProvider4.Hyperbolic,
                "nebius" => ResponseItemVariant2AvailableInferenceProviderProvider4.Nebius,
                "novita" => ResponseItemVariant2AvailableInferenceProviderProvider4.Novita,
                "nscale" => ResponseItemVariant2AvailableInferenceProviderProvider4.Nscale,
                "nvidia" => ResponseItemVariant2AvailableInferenceProviderProvider4.Nvidia,
                "openai" => ResponseItemVariant2AvailableInferenceProviderProvider4.Openai,
                "ovhcloud" => ResponseItemVariant2AvailableInferenceProviderProvider4.Ovhcloud,
                "publicai" => ResponseItemVariant2AvailableInferenceProviderProvider4.Publicai,
                "replicate" => ResponseItemVariant2AvailableInferenceProviderProvider4.Replicate,
                "sambanova" => ResponseItemVariant2AvailableInferenceProviderProvider4.Sambanova,
                "scaleway" => ResponseItemVariant2AvailableInferenceProviderProvider4.Scaleway,
                "together" => ResponseItemVariant2AvailableInferenceProviderProvider4.Together,
                "wavespeed" => ResponseItemVariant2AvailableInferenceProviderProvider4.Wavespeed,
                "zai-org" => ResponseItemVariant2AvailableInferenceProviderProvider4.ZaiOrg,
                _ => null,
            };
        }
    }
}