
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType6
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
    public static class ResponseItemType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType6 value)
        {
            return value switch
            {
                ResponseItemType6.Benchmark => "benchmark",
                ResponseItemType6.TaskCategories => "task_categories",
                ResponseItemType6.SizeCategories => "size_categories",
                ResponseItemType6.Modality => "modality",
                ResponseItemType6.Format => "format",
                ResponseItemType6.Library => "library",
                ResponseItemType6.Language => "language",
                ResponseItemType6.License => "license",
                ResponseItemType6.Arxiv => "arxiv",
                ResponseItemType6.Doi => "doi",
                ResponseItemType6.Region => "region",
                ResponseItemType6.Other => "other",
                ResponseItemType6.TaskIds => "task_ids",
                ResponseItemType6.AnnotationsCreators => "annotations_creators",
                ResponseItemType6.LanguageCreators => "language_creators",
                ResponseItemType6.Multilinguality => "multilinguality",
                ResponseItemType6.SourceDatasets => "source_datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType6? ToEnum(string value)
        {
            return value switch
            {
                "benchmark" => ResponseItemType6.Benchmark,
                "task_categories" => ResponseItemType6.TaskCategories,
                "size_categories" => ResponseItemType6.SizeCategories,
                "modality" => ResponseItemType6.Modality,
                "format" => ResponseItemType6.Format,
                "library" => ResponseItemType6.Library,
                "language" => ResponseItemType6.Language,
                "license" => ResponseItemType6.License,
                "arxiv" => ResponseItemType6.Arxiv,
                "doi" => ResponseItemType6.Doi,
                "region" => ResponseItemType6.Region,
                "other" => ResponseItemType6.Other,
                "task_ids" => ResponseItemType6.TaskIds,
                "annotations_creators" => ResponseItemType6.AnnotationsCreators,
                "language_creators" => ResponseItemType6.LanguageCreators,
                "multilinguality" => ResponseItemType6.Multilinguality,
                "source_datasets" => ResponseItemType6.SourceDatasets,
                _ => null,
            };
        }
    }
}