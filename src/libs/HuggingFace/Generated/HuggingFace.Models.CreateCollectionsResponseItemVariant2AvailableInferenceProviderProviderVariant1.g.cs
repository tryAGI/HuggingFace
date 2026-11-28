
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1
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
    public static class CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq => "groq",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita => "novita",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together => "together",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}