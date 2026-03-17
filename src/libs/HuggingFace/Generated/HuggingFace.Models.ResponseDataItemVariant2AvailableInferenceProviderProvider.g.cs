
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AvailableInferenceProviderProvider
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
    public static class ResponseDataItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Together => "together",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                ResponseDataItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => ResponseDataItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => ResponseDataItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => ResponseDataItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => ResponseDataItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}