
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType5
    {
        /// <summary>
        /// 
        /// </summary>
        PipelineTag,
        /// <summary>
        /// 
        /// </summary>
        Library,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        License,
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
        /// <summary>
        /// 
        /// </summary>
        Doi,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType5 value)
        {
            return value switch
            {
                ResponseItemType5.PipelineTag => "pipeline_tag",
                ResponseItemType5.Library => "library",
                ResponseItemType5.Dataset => "dataset",
                ResponseItemType5.Language => "language",
                ResponseItemType5.License => "license",
                ResponseItemType5.Arxiv => "arxiv",
                ResponseItemType5.Doi => "doi",
                ResponseItemType5.Region => "region",
                ResponseItemType5.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType5? ToEnum(string value)
        {
            return value switch
            {
                "pipeline_tag" => ResponseItemType5.PipelineTag,
                "library" => ResponseItemType5.Library,
                "dataset" => ResponseItemType5.Dataset,
                "language" => ResponseItemType5.Language,
                "license" => ResponseItemType5.License,
                "arxiv" => ResponseItemType5.Arxiv,
                "doi" => ResponseItemType5.Doi,
                "region" => ResponseItemType5.Region,
                "other" => ResponseItemType5.Other,
                _ => null,
            };
        }
    }
}