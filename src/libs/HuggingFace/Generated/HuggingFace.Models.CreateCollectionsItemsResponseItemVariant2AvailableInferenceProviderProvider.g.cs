
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
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
        Novita,
        /// <summary>
        /// 
        /// </summary>
        Nscale,
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Together => "together",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Baseten,
                "cerebras" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "cohere" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.HfInference,
                "novita" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Nscale,
                "openai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Replicate,
                "scaleway" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}