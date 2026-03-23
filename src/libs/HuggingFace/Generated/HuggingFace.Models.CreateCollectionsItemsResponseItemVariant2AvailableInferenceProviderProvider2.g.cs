
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Baseten => "baseten",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs => "black-forest-labs",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras => "cerebras",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai => "clarifai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Cohere => "cohere",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra => "deepinfra",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FalAi => "fal-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi => "featherless-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi => "fireworks-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Groq => "groq",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.HfInference => "hf-inference",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic => "hyperbolic",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nebius => "nebius",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Novita => "novita",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nscale => "nscale",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia => "nvidia",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Openai => "openai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud => "ovhcloud",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Publicai => "publicai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Replicate => "replicate",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova => "sambanova",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway => "scaleway",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Together => "together",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed => "wavespeed",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Baseten,
                "black-forest-labs" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.BlackForestLabs,
                "cerebras" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Cerebras,
                "clarifai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Clarifai,
                "cohere" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Cohere,
                "deepinfra" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Deepinfra,
                "fal-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FalAi,
                "featherless-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FeatherlessAi,
                "fireworks-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.FireworksAi,
                "groq" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Groq,
                "hf-inference" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.HfInference,
                "hyperbolic" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Hyperbolic,
                "nebius" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nebius,
                "novita" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Novita,
                "nscale" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nscale,
                "nvidia" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Nvidia,
                "openai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Openai,
                "ovhcloud" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Ovhcloud,
                "publicai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Publicai,
                "replicate" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Replicate,
                "sambanova" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Sambanova,
                "scaleway" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Scaleway,
                "together" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Together,
                "wavespeed" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.Wavespeed,
                "zai-org" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2.ZaiOrg,
                _ => null,
            };
        }
    }
}