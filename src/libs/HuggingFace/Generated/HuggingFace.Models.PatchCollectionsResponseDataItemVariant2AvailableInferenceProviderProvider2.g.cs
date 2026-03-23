
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Baseten => "baseten",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs => "black-forest-labs",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Cerebras => "cerebras",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Clarifai => "clarifai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Cohere => "cohere",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Deepinfra => "deepinfra",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FalAi => "fal-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi => "featherless-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FireworksAi => "fireworks-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Groq => "groq",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.HfInference => "hf-inference",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Hyperbolic => "hyperbolic",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nebius => "nebius",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Novita => "novita",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nscale => "nscale",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nvidia => "nvidia",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Openai => "openai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Ovhcloud => "ovhcloud",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Publicai => "publicai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Replicate => "replicate",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Sambanova => "sambanova",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Scaleway => "scaleway",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Together => "together",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Wavespeed => "wavespeed",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Baseten,
                "black-forest-labs" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs,
                "cerebras" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Cerebras,
                "clarifai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Clarifai,
                "cohere" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Cohere,
                "deepinfra" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Deepinfra,
                "fal-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FalAi,
                "featherless-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi,
                "fireworks-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.FireworksAi,
                "groq" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Groq,
                "hf-inference" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.HfInference,
                "hyperbolic" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Hyperbolic,
                "nebius" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nebius,
                "novita" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Novita,
                "nscale" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nscale,
                "nvidia" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Nvidia,
                "openai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Openai,
                "ovhcloud" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Ovhcloud,
                "publicai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Publicai,
                "replicate" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Replicate,
                "sambanova" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Sambanova,
                "scaleway" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Scaleway,
                "together" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Together,
                "wavespeed" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.Wavespeed,
                "zai-org" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2.ZaiOrg,
                _ => null,
            };
        }
    }
}