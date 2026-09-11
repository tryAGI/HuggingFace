
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutPartnersModelsStatusProvider
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
    public static class PutPartnersModelsStatusProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutPartnersModelsStatusProvider value)
        {
            return value switch
            {
                PutPartnersModelsStatusProvider.Baseten => "baseten",
                PutPartnersModelsStatusProvider.Cerebras => "cerebras",
                PutPartnersModelsStatusProvider.Cohere => "cohere",
                PutPartnersModelsStatusProvider.Deepinfra => "deepinfra",
                PutPartnersModelsStatusProvider.FalAi => "fal-ai",
                PutPartnersModelsStatusProvider.FeatherlessAi => "featherless-ai",
                PutPartnersModelsStatusProvider.FireworksAi => "fireworks-ai",
                PutPartnersModelsStatusProvider.Groq => "groq",
                PutPartnersModelsStatusProvider.HfInference => "hf-inference",
                PutPartnersModelsStatusProvider.Novita => "novita",
                PutPartnersModelsStatusProvider.Nscale => "nscale",
                PutPartnersModelsStatusProvider.Ovhcloud => "ovhcloud",
                PutPartnersModelsStatusProvider.Publicai => "publicai",
                PutPartnersModelsStatusProvider.Replicate => "replicate",
                PutPartnersModelsStatusProvider.Scaleway => "scaleway",
                PutPartnersModelsStatusProvider.Together => "together",
                PutPartnersModelsStatusProvider.Wavespeed => "wavespeed",
                PutPartnersModelsStatusProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutPartnersModelsStatusProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => PutPartnersModelsStatusProvider.Baseten,
                "cerebras" => PutPartnersModelsStatusProvider.Cerebras,
                "cohere" => PutPartnersModelsStatusProvider.Cohere,
                "deepinfra" => PutPartnersModelsStatusProvider.Deepinfra,
                "fal-ai" => PutPartnersModelsStatusProvider.FalAi,
                "featherless-ai" => PutPartnersModelsStatusProvider.FeatherlessAi,
                "fireworks-ai" => PutPartnersModelsStatusProvider.FireworksAi,
                "groq" => PutPartnersModelsStatusProvider.Groq,
                "hf-inference" => PutPartnersModelsStatusProvider.HfInference,
                "novita" => PutPartnersModelsStatusProvider.Novita,
                "nscale" => PutPartnersModelsStatusProvider.Nscale,
                "ovhcloud" => PutPartnersModelsStatusProvider.Ovhcloud,
                "publicai" => PutPartnersModelsStatusProvider.Publicai,
                "replicate" => PutPartnersModelsStatusProvider.Replicate,
                "scaleway" => PutPartnersModelsStatusProvider.Scaleway,
                "together" => PutPartnersModelsStatusProvider.Together,
                "wavespeed" => PutPartnersModelsStatusProvider.Wavespeed,
                "zai-org" => PutPartnersModelsStatusProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}