
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProvider5
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
    public static class ResponseItemVariant2AvailableInferenceProviderProvider5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProvider5 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProvider5.Baseten => "baseten",
                ResponseItemVariant2AvailableInferenceProviderProvider5.BlackForestLabs => "black-forest-labs",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Cerebras => "cerebras",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Clarifai => "clarifai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Cohere => "cohere",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Deepinfra => "deepinfra",
                ResponseItemVariant2AvailableInferenceProviderProvider5.FalAi => "fal-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.FeatherlessAi => "featherless-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.FireworksAi => "fireworks-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Groq => "groq",
                ResponseItemVariant2AvailableInferenceProviderProvider5.HfInference => "hf-inference",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Hyperbolic => "hyperbolic",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Nebius => "nebius",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Novita => "novita",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Nscale => "nscale",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Nvidia => "nvidia",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Openai => "openai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Ovhcloud => "ovhcloud",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Publicai => "publicai",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Replicate => "replicate",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Sambanova => "sambanova",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Scaleway => "scaleway",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Together => "together",
                ResponseItemVariant2AvailableInferenceProviderProvider5.Wavespeed => "wavespeed",
                ResponseItemVariant2AvailableInferenceProviderProvider5.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProvider5? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseItemVariant2AvailableInferenceProviderProvider5.Baseten,
                "black-forest-labs" => ResponseItemVariant2AvailableInferenceProviderProvider5.BlackForestLabs,
                "cerebras" => ResponseItemVariant2AvailableInferenceProviderProvider5.Cerebras,
                "clarifai" => ResponseItemVariant2AvailableInferenceProviderProvider5.Clarifai,
                "cohere" => ResponseItemVariant2AvailableInferenceProviderProvider5.Cohere,
                "deepinfra" => ResponseItemVariant2AvailableInferenceProviderProvider5.Deepinfra,
                "fal-ai" => ResponseItemVariant2AvailableInferenceProviderProvider5.FalAi,
                "featherless-ai" => ResponseItemVariant2AvailableInferenceProviderProvider5.FeatherlessAi,
                "fireworks-ai" => ResponseItemVariant2AvailableInferenceProviderProvider5.FireworksAi,
                "groq" => ResponseItemVariant2AvailableInferenceProviderProvider5.Groq,
                "hf-inference" => ResponseItemVariant2AvailableInferenceProviderProvider5.HfInference,
                "hyperbolic" => ResponseItemVariant2AvailableInferenceProviderProvider5.Hyperbolic,
                "nebius" => ResponseItemVariant2AvailableInferenceProviderProvider5.Nebius,
                "novita" => ResponseItemVariant2AvailableInferenceProviderProvider5.Novita,
                "nscale" => ResponseItemVariant2AvailableInferenceProviderProvider5.Nscale,
                "nvidia" => ResponseItemVariant2AvailableInferenceProviderProvider5.Nvidia,
                "openai" => ResponseItemVariant2AvailableInferenceProviderProvider5.Openai,
                "ovhcloud" => ResponseItemVariant2AvailableInferenceProviderProvider5.Ovhcloud,
                "publicai" => ResponseItemVariant2AvailableInferenceProviderProvider5.Publicai,
                "replicate" => ResponseItemVariant2AvailableInferenceProviderProvider5.Replicate,
                "sambanova" => ResponseItemVariant2AvailableInferenceProviderProvider5.Sambanova,
                "scaleway" => ResponseItemVariant2AvailableInferenceProviderProvider5.Scaleway,
                "together" => ResponseItemVariant2AvailableInferenceProviderProvider5.Together,
                "wavespeed" => ResponseItemVariant2AvailableInferenceProviderProvider5.Wavespeed,
                "zai-org" => ResponseItemVariant2AvailableInferenceProviderProvider5.ZaiOrg,
                _ => null,
            };
        }
    }
}