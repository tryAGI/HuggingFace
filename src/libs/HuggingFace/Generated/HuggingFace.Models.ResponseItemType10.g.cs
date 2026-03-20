
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType10
    {
        /// <summary>
        /// 
        /// </summary>
        Benchmark,
        /// <summary>
        /// 
        /// </summary>
        TaskCategories,
        /// <summary>
        /// 
        /// </summary>
        SizeCategories,
        /// <summary>
        /// 
        /// </summary>
        Modality,
        /// <summary>
        /// 
        /// </summary>
        Format,
        /// <summary>
        /// 
        /// </summary>
        Library,
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
        /// <summary>
        /// 
        /// </summary>
        TaskIds,
        /// <summary>
        /// 
        /// </summary>
        AnnotationsCreators,
        /// <summary>
        /// 
        /// </summary>
        LanguageCreators,
        /// <summary>
        /// 
        /// </summary>
        Multilinguality,
        /// <summary>
        /// 
        /// </summary>
        SourceDatasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemType10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType10 value)
        {
            return value switch
            {
                ResponseItemType10.Benchmark => "benchmark",
                ResponseItemType10.TaskCategories => "task_categories",
                ResponseItemType10.SizeCategories => "size_categories",
                ResponseItemType10.Modality => "modality",
                ResponseItemType10.Format => "format",
                ResponseItemType10.Library => "library",
                ResponseItemType10.Language => "language",
                ResponseItemType10.License => "license",
                ResponseItemType10.Arxiv => "arxiv",
                ResponseItemType10.Doi => "doi",
                ResponseItemType10.Region => "region",
                ResponseItemType10.Other => "other",
                ResponseItemType10.TaskIds => "task_ids",
                ResponseItemType10.AnnotationsCreators => "annotations_creators",
                ResponseItemType10.LanguageCreators => "language_creators",
                ResponseItemType10.Multilinguality => "multilinguality",
                ResponseItemType10.SourceDatasets => "source_datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType10? ToEnum(string value)
        {
            return value switch
            {
                "benchmark" => ResponseItemType10.Benchmark,
                "task_categories" => ResponseItemType10.TaskCategories,
                "size_categories" => ResponseItemType10.SizeCategories,
                "modality" => ResponseItemType10.Modality,
                "format" => ResponseItemType10.Format,
                "library" => ResponseItemType10.Library,
                "language" => ResponseItemType10.Language,
                "license" => ResponseItemType10.License,
                "arxiv" => ResponseItemType10.Arxiv,
                "doi" => ResponseItemType10.Doi,
                "region" => ResponseItemType10.Region,
                "other" => ResponseItemType10.Other,
                "task_ids" => ResponseItemType10.TaskIds,
                "annotations_creators" => ResponseItemType10.AnnotationsCreators,
                "language_creators" => ResponseItemType10.LanguageCreators,
                "multilinguality" => ResponseItemType10.Multilinguality,
                "source_datasets" => ResponseItemType10.SourceDatasets,
                _ => null,
            };
        }
    }
}