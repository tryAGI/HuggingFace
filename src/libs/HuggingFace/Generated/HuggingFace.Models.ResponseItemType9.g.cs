
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType9
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
    public static class ResponseItemType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType9 value)
        {
            return value switch
            {
                ResponseItemType9.PipelineTag => "pipeline_tag",
                ResponseItemType9.Library => "library",
                ResponseItemType9.Dataset => "dataset",
                ResponseItemType9.Language => "language",
                ResponseItemType9.License => "license",
                ResponseItemType9.Arxiv => "arxiv",
                ResponseItemType9.Doi => "doi",
                ResponseItemType9.Region => "region",
                ResponseItemType9.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType9? ToEnum(string value)
        {
            return value switch
            {
                "pipeline_tag" => ResponseItemType9.PipelineTag,
                "library" => ResponseItemType9.Library,
                "dataset" => ResponseItemType9.Dataset,
                "language" => ResponseItemType9.Language,
                "license" => ResponseItemType9.License,
                "arxiv" => ResponseItemType9.Arxiv,
                "doi" => ResponseItemType9.Doi,
                "region" => ResponseItemType9.Region,
                "other" => ResponseItemType9.Other,
                _ => null,
            };
        }
    }
}