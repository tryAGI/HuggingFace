
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPartnersModelsProvider
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
    public static class GetPartnersModelsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPartnersModelsProvider value)
        {
            return value switch
            {
                GetPartnersModelsProvider.Baseten => "baseten",
                GetPartnersModelsProvider.Cerebras => "cerebras",
                GetPartnersModelsProvider.Cohere => "cohere",
                GetPartnersModelsProvider.Deepinfra => "deepinfra",
                GetPartnersModelsProvider.FalAi => "fal-ai",
                GetPartnersModelsProvider.FeatherlessAi => "featherless-ai",
                GetPartnersModelsProvider.FireworksAi => "fireworks-ai",
                GetPartnersModelsProvider.Groq => "groq",
                GetPartnersModelsProvider.HfInference => "hf-inference",
                GetPartnersModelsProvider.Novita => "novita",
                GetPartnersModelsProvider.Nscale => "nscale",
                GetPartnersModelsProvider.Ovhcloud => "ovhcloud",
                GetPartnersModelsProvider.Publicai => "publicai",
                GetPartnersModelsProvider.Replicate => "replicate",
                GetPartnersModelsProvider.Scaleway => "scaleway",
                GetPartnersModelsProvider.Together => "together",
                GetPartnersModelsProvider.Wavespeed => "wavespeed",
                GetPartnersModelsProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPartnersModelsProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetPartnersModelsProvider.Baseten,
                "cerebras" => GetPartnersModelsProvider.Cerebras,
                "cohere" => GetPartnersModelsProvider.Cohere,
                "deepinfra" => GetPartnersModelsProvider.Deepinfra,
                "fal-ai" => GetPartnersModelsProvider.FalAi,
                "featherless-ai" => GetPartnersModelsProvider.FeatherlessAi,
                "fireworks-ai" => GetPartnersModelsProvider.FireworksAi,
                "groq" => GetPartnersModelsProvider.Groq,
                "hf-inference" => GetPartnersModelsProvider.HfInference,
                "novita" => GetPartnersModelsProvider.Novita,
                "nscale" => GetPartnersModelsProvider.Nscale,
                "ovhcloud" => GetPartnersModelsProvider.Ovhcloud,
                "publicai" => GetPartnersModelsProvider.Publicai,
                "replicate" => GetPartnersModelsProvider.Replicate,
                "scaleway" => GetPartnersModelsProvider.Scaleway,
                "together" => GetPartnersModelsProvider.Together,
                "wavespeed" => GetPartnersModelsProvider.Wavespeed,
                "zai-org" => GetPartnersModelsProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}