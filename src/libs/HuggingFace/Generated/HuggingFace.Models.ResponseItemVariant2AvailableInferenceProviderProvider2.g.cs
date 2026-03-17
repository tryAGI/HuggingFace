
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AvailableInferenceProviderProvider2
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
    public static class ResponseItemVariant2AvailableInferenceProviderProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AvailableInferenceProviderProvider2 value)
        {
            return value switch
            {
                ResponseItemVariant2AvailableInferenceProviderProvider2.Baseten => "baseten",
                ResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs => "black-forest-labs",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras => "cerebras",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai => "clarifai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Cohere => "cohere",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra => "deepinfra",
                ResponseItemVariant2AvailableInferenceProviderProvider2.FalAi => "fal-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi => "featherless-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi => "fireworks-ai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Groq => "groq",
                ResponseItemVariant2AvailableInferenceProviderProvider2.HfInference => "hf-inference",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic => "hyperbolic",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Nebius => "nebius",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Novita => "novita",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Nscale => "nscale",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia => "nvidia",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Openai => "openai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud => "ovhcloud",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Publicai => "publicai",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Replicate => "replicate",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova => "sambanova",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway => "scaleway",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Together => "together",
                ResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed => "wavespeed",
                ResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AvailableInferenceProviderProvider2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseItemVariant2AvailableInferenceProviderProvider2.Baseten,
                "black-forest-labs" => ResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs,
                "cerebras" => ResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras,
                "clarifai" => ResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai,
                "cohere" => ResponseItemVariant2AvailableInferenceProviderProvider2.Cohere,
                "deepinfra" => ResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra,
                "fal-ai" => ResponseItemVariant2AvailableInferenceProviderProvider2.FalAi,
                "featherless-ai" => ResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi,
                "fireworks-ai" => ResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi,
                "groq" => ResponseItemVariant2AvailableInferenceProviderProvider2.Groq,
                "hf-inference" => ResponseItemVariant2AvailableInferenceProviderProvider2.HfInference,
                "hyperbolic" => ResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic,
                "nebius" => ResponseItemVariant2AvailableInferenceProviderProvider2.Nebius,
                "novita" => ResponseItemVariant2AvailableInferenceProviderProvider2.Novita,
                "nscale" => ResponseItemVariant2AvailableInferenceProviderProvider2.Nscale,
                "nvidia" => ResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia,
                "openai" => ResponseItemVariant2AvailableInferenceProviderProvider2.Openai,
                "ovhcloud" => ResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud,
                "publicai" => ResponseItemVariant2AvailableInferenceProviderProvider2.Publicai,
                "replicate" => ResponseItemVariant2AvailableInferenceProviderProvider2.Replicate,
                "sambanova" => ResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova,
                "scaleway" => ResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway,
                "together" => ResponseItemVariant2AvailableInferenceProviderProvider2.Together,
                "wavespeed" => ResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed,
                "zai-org" => ResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg,
                _ => null,
            };
        }
    }
}