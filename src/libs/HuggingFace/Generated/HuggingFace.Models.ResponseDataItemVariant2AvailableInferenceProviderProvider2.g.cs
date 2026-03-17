
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderProvider2
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderProvider2 value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Baseten => "baseten",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs => "black-forest-labs",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Cerebras => "cerebras",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Clarifai => "clarifai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Cohere => "cohere",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Deepinfra => "deepinfra",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.FalAi => "fal-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi => "featherless-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.FireworksAi => "fireworks-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Groq => "groq",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.HfInference => "hf-inference",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Hyperbolic => "hyperbolic",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nebius => "nebius",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Novita => "novita",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nscale => "nscale",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nvidia => "nvidia",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Openai => "openai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Ovhcloud => "ovhcloud",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Publicai => "publicai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Replicate => "replicate",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Sambanova => "sambanova",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Scaleway => "scaleway",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Together => "together",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.Wavespeed => "wavespeed",
                ResponseDataItemVariant2AvailableInferenceProviderProvider2.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderProvider2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Baseten,
                "black-forest-labs" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs,
                "cerebras" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Cerebras,
                "clarifai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Clarifai,
                "cohere" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Cohere,
                "deepinfra" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Deepinfra,
                "fal-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.FalAi,
                "featherless-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi,
                "fireworks-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.FireworksAi,
                "groq" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Groq,
                "hf-inference" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.HfInference,
                "hyperbolic" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Hyperbolic,
                "nebius" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nebius,
                "novita" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Novita,
                "nscale" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nscale,
                "nvidia" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Nvidia,
                "openai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Openai,
                "ovhcloud" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Ovhcloud,
                "publicai" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Publicai,
                "replicate" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Replicate,
                "sambanova" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Sambanova,
                "scaleway" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Scaleway,
                "together" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Together,
                "wavespeed" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.Wavespeed,
                "zai-org" => ResponseDataItemVariant2AvailableInferenceProviderProvider2.ZaiOrg,
                _ => null,
            };
        }
    }
}