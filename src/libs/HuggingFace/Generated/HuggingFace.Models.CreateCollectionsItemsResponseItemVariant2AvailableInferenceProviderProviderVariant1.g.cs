
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1
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
        Openrouter,
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
    public static class CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq => "groq",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita => "novita",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together => "together",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}