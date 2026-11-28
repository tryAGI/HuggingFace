
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2
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
        Coreweave,
        /// <summary>
        ///
        /// </summary>
        Deepinfra,
        /// <summary>
        ///
        /// </summary>
        Deepseek,
        /// <summary>
        ///
        /// </summary>
        Digitalocean,
        /// <summary>
        ///
        /// </summary>
        Featherless,
        /// <summary>
        ///
        /// </summary>
        Fireworks,
        /// <summary>
        ///
        /// </summary>
        Liquid,
        /// <summary>
        ///
        /// </summary>
        Mistral,
        /// <summary>
        ///
        /// </summary>
        Moonshotai,
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
        Parasail,
        /// <summary>
        ///
        /// </summary>
        Primeintellect,
        /// <summary>
        ///
        /// </summary>
        Reka,
        /// <summary>
        ///
        /// </summary>
        Tencent,
        /// <summary>
        ///
        /// </summary>
        Together,
        /// <summary>
        ///
        /// </summary>
        ZAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Baseten => "baseten",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras => "cerebras",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Cohere => "cohere",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave => "coreweave",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra => "deepinfra",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek => "deepseek",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean => "digitalocean",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Featherless => "featherless",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks => "fireworks",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Liquid => "liquid",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Mistral => "mistral",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai => "moonshotai",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Nebius => "nebius",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Novita => "novita",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Parasail => "parasail",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect => "primeintellect",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Reka => "reka",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Tencent => "tencent",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Together => "together",
                PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.ZAi => "z-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Baseten,
                "cerebras" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Cerebras,
                "cohere" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Cohere,
                "coreweave" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Coreweave,
                "deepinfra" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Deepinfra,
                "deepseek" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Deepseek,
                "digitalocean" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Digitalocean,
                "featherless" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Featherless,
                "fireworks" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Fireworks,
                "liquid" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Liquid,
                "mistral" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Mistral,
                "moonshotai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Moonshotai,
                "nebius" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Nebius,
                "novita" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Novita,
                "parasail" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Parasail,
                "primeintellect" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Primeintellect,
                "reka" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Reka,
                "tencent" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Tencent,
                "together" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.Together,
                "z-ai" => PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderVariant2.ZAi,
                _ => null,
            };
        }
    }
}