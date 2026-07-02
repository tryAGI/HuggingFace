
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Together => "together",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Baseten,
                "cerebras" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "cohere" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.HfInference,
                "novita" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Nscale,
                "openai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Replicate,
                "scaleway" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}