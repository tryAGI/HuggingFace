
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Type4
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
    public static class Type4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type4 value)
        {
            return value switch
            {
                Type4.Benchmark => "benchmark",
                Type4.TaskCategories => "task_categories",
                Type4.SizeCategories => "size_categories",
                Type4.Modality => "modality",
                Type4.Format => "format",
                Type4.Library => "library",
                Type4.Language => "language",
                Type4.License => "license",
                Type4.Arxiv => "arxiv",
                Type4.Doi => "doi",
                Type4.Region => "region",
                Type4.Other => "other",
                Type4.TaskIds => "task_ids",
                Type4.AnnotationsCreators => "annotations_creators",
                Type4.LanguageCreators => "language_creators",
                Type4.Multilinguality => "multilinguality",
                Type4.SourceDatasets => "source_datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type4? ToEnum(string value)
        {
            return value switch
            {
                "benchmark" => Type4.Benchmark,
                "task_categories" => Type4.TaskCategories,
                "size_categories" => Type4.SizeCategories,
                "modality" => Type4.Modality,
                "format" => Type4.Format,
                "library" => Type4.Library,
                "language" => Type4.Language,
                "license" => Type4.License,
                "arxiv" => Type4.Arxiv,
                "doi" => Type4.Doi,
                "region" => Type4.Region,
                "other" => Type4.Other,
                "task_ids" => Type4.TaskIds,
                "annotations_creators" => Type4.AnnotationsCreators,
                "language_creators" => Type4.LanguageCreators,
                "multilinguality" => Type4.Multilinguality,
                "source_datasets" => Type4.SourceDatasets,
                _ => null,
            };
        }
    }
}