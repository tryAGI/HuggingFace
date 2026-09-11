
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePartnersModelsProvider
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
    public static class CreatePartnersModelsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePartnersModelsProvider value)
        {
            return value switch
            {
                CreatePartnersModelsProvider.Baseten => "baseten",
                CreatePartnersModelsProvider.Cerebras => "cerebras",
                CreatePartnersModelsProvider.Cohere => "cohere",
                CreatePartnersModelsProvider.Deepinfra => "deepinfra",
                CreatePartnersModelsProvider.FalAi => "fal-ai",
                CreatePartnersModelsProvider.FeatherlessAi => "featherless-ai",
                CreatePartnersModelsProvider.FireworksAi => "fireworks-ai",
                CreatePartnersModelsProvider.Groq => "groq",
                CreatePartnersModelsProvider.HfInference => "hf-inference",
                CreatePartnersModelsProvider.Novita => "novita",
                CreatePartnersModelsProvider.Nscale => "nscale",
                CreatePartnersModelsProvider.Ovhcloud => "ovhcloud",
                CreatePartnersModelsProvider.Publicai => "publicai",
                CreatePartnersModelsProvider.Replicate => "replicate",
                CreatePartnersModelsProvider.Scaleway => "scaleway",
                CreatePartnersModelsProvider.Together => "together",
                CreatePartnersModelsProvider.Wavespeed => "wavespeed",
                CreatePartnersModelsProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePartnersModelsProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => CreatePartnersModelsProvider.Baseten,
                "cerebras" => CreatePartnersModelsProvider.Cerebras,
                "cohere" => CreatePartnersModelsProvider.Cohere,
                "deepinfra" => CreatePartnersModelsProvider.Deepinfra,
                "fal-ai" => CreatePartnersModelsProvider.FalAi,
                "featherless-ai" => CreatePartnersModelsProvider.FeatherlessAi,
                "fireworks-ai" => CreatePartnersModelsProvider.FireworksAi,
                "groq" => CreatePartnersModelsProvider.Groq,
                "hf-inference" => CreatePartnersModelsProvider.HfInference,
                "novita" => CreatePartnersModelsProvider.Novita,
                "nscale" => CreatePartnersModelsProvider.Nscale,
                "ovhcloud" => CreatePartnersModelsProvider.Ovhcloud,
                "publicai" => CreatePartnersModelsProvider.Publicai,
                "replicate" => CreatePartnersModelsProvider.Replicate,
                "scaleway" => CreatePartnersModelsProvider.Scaleway,
                "together" => CreatePartnersModelsProvider.Together,
                "wavespeed" => CreatePartnersModelsProvider.Wavespeed,
                "zai-org" => CreatePartnersModelsProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}