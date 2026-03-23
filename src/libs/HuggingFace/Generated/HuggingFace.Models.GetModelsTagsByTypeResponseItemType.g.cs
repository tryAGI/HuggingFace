
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTagsByTypeResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Doi,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Library,
        /// <summary>
        /// 
        /// </summary>
        License,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PipelineTag,
        /// <summary>
        /// 
        /// </summary>
        Region,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsTagsByTypeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTagsByTypeResponseItemType value)
        {
            return value switch
            {
                GetModelsTagsByTypeResponseItemType.Arxiv => "arxiv",
                GetModelsTagsByTypeResponseItemType.Dataset => "dataset",
                GetModelsTagsByTypeResponseItemType.Doi => "doi",
                GetModelsTagsByTypeResponseItemType.Language => "language",
                GetModelsTagsByTypeResponseItemType.Library => "library",
                GetModelsTagsByTypeResponseItemType.License => "license",
                GetModelsTagsByTypeResponseItemType.Other => "other",
                GetModelsTagsByTypeResponseItemType.PipelineTag => "pipeline_tag",
                GetModelsTagsByTypeResponseItemType.Region => "region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTagsByTypeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "arxiv" => GetModelsTagsByTypeResponseItemType.Arxiv,
                "dataset" => GetModelsTagsByTypeResponseItemType.Dataset,
                "doi" => GetModelsTagsByTypeResponseItemType.Doi,
                "language" => GetModelsTagsByTypeResponseItemType.Language,
                "library" => GetModelsTagsByTypeResponseItemType.Library,
                "license" => GetModelsTagsByTypeResponseItemType.License,
                "other" => GetModelsTagsByTypeResponseItemType.Other,
                "pipeline_tag" => GetModelsTagsByTypeResponseItemType.PipelineTag,
                "region" => GetModelsTagsByTypeResponseItemType.Region,
                _ => null,
            };
        }
    }
}