
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1
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
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Groq => "groq",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Novita => "novita",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Together => "together",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}