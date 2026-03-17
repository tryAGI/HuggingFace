
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Type3
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
    public static class Type3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type3 value)
        {
            return value switch
            {
                Type3.PipelineTag => "pipeline_tag",
                Type3.Library => "library",
                Type3.Dataset => "dataset",
                Type3.Language => "language",
                Type3.License => "license",
                Type3.Arxiv => "arxiv",
                Type3.Doi => "doi",
                Type3.Region => "region",
                Type3.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type3? ToEnum(string value)
        {
            return value switch
            {
                "pipeline_tag" => Type3.PipelineTag,
                "library" => Type3.Library,
                "dataset" => Type3.Dataset,
                "language" => Type3.Language,
                "license" => Type3.License,
                "arxiv" => Type3.Arxiv,
                "doi" => Type3.Doi,
                "region" => Type3.Region,
                "other" => Type3.Other,
                _ => null,
            };
        }
    }
}