
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTagsByTypeType
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
    public static class GetModelsTagsByTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTagsByTypeType value)
        {
            return value switch
            {
                GetModelsTagsByTypeType.Arxiv => "arxiv",
                GetModelsTagsByTypeType.Dataset => "dataset",
                GetModelsTagsByTypeType.Doi => "doi",
                GetModelsTagsByTypeType.Language => "language",
                GetModelsTagsByTypeType.Library => "library",
                GetModelsTagsByTypeType.License => "license",
                GetModelsTagsByTypeType.Other => "other",
                GetModelsTagsByTypeType.PipelineTag => "pipeline_tag",
                GetModelsTagsByTypeType.Region => "region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTagsByTypeType? ToEnum(string value)
        {
            return value switch
            {
                "arxiv" => GetModelsTagsByTypeType.Arxiv,
                "dataset" => GetModelsTagsByTypeType.Dataset,
                "doi" => GetModelsTagsByTypeType.Doi,
                "language" => GetModelsTagsByTypeType.Language,
                "library" => GetModelsTagsByTypeType.Library,
                "license" => GetModelsTagsByTypeType.License,
                "other" => GetModelsTagsByTypeType.Other,
                "pipeline_tag" => GetModelsTagsByTypeType.PipelineTag,
                "region" => GetModelsTagsByTypeType.Region,
                _ => null,
            };
        }
    }
}