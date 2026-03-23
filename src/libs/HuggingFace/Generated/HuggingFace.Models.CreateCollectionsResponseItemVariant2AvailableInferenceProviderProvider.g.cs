
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Together => "together",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}