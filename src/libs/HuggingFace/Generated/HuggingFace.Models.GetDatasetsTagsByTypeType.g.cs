
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTagsByTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        AnnotationsCreators,
        /// <summary>
        /// 
        /// </summary>
        Arxiv,
        /// <summary>
        /// 
        /// </summary>
        Benchmark,
        /// <summary>
        /// 
        /// </summary>
        Doi,
        /// <summary>
        /// 
        /// </summary>
        Format,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        LanguageCreators,
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
        Modality,
        /// <summary>
        /// 
        /// </summary>
        Multilinguality,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        SizeCategories,
        /// <summary>
        /// 
        /// </summary>
        SourceDatasets,
        /// <summary>
        /// 
        /// </summary>
        TaskCategories,
        /// <summary>
        /// 
        /// </summary>
        TaskIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsTagsByTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTagsByTypeType value)
        {
            return value switch
            {
                GetDatasetsTagsByTypeType.AnnotationsCreators => "annotations_creators",
                GetDatasetsTagsByTypeType.Arxiv => "arxiv",
                GetDatasetsTagsByTypeType.Benchmark => "benchmark",
                GetDatasetsTagsByTypeType.Doi => "doi",
                GetDatasetsTagsByTypeType.Format => "format",
                GetDatasetsTagsByTypeType.Language => "language",
                GetDatasetsTagsByTypeType.LanguageCreators => "language_creators",
                GetDatasetsTagsByTypeType.Library => "library",
                GetDatasetsTagsByTypeType.License => "license",
                GetDatasetsTagsByTypeType.Modality => "modality",
                GetDatasetsTagsByTypeType.Multilinguality => "multilinguality",
                GetDatasetsTagsByTypeType.Other => "other",
                GetDatasetsTagsByTypeType.Region => "region",
                GetDatasetsTagsByTypeType.SizeCategories => "size_categories",
                GetDatasetsTagsByTypeType.SourceDatasets => "source_datasets",
                GetDatasetsTagsByTypeType.TaskCategories => "task_categories",
                GetDatasetsTagsByTypeType.TaskIds => "task_ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTagsByTypeType? ToEnum(string value)
        {
            return value switch
            {
                "annotations_creators" => GetDatasetsTagsByTypeType.AnnotationsCreators,
                "arxiv" => GetDatasetsTagsByTypeType.Arxiv,
                "benchmark" => GetDatasetsTagsByTypeType.Benchmark,
                "doi" => GetDatasetsTagsByTypeType.Doi,
                "format" => GetDatasetsTagsByTypeType.Format,
                "language" => GetDatasetsTagsByTypeType.Language,
                "language_creators" => GetDatasetsTagsByTypeType.LanguageCreators,
                "library" => GetDatasetsTagsByTypeType.Library,
                "license" => GetDatasetsTagsByTypeType.License,
                "modality" => GetDatasetsTagsByTypeType.Modality,
                "multilinguality" => GetDatasetsTagsByTypeType.Multilinguality,
                "other" => GetDatasetsTagsByTypeType.Other,
                "region" => GetDatasetsTagsByTypeType.Region,
                "size_categories" => GetDatasetsTagsByTypeType.SizeCategories,
                "source_datasets" => GetDatasetsTagsByTypeType.SourceDatasets,
                "task_categories" => GetDatasetsTagsByTypeType.TaskCategories,
                "task_ids" => GetDatasetsTagsByTypeType.TaskIds,
                _ => null,
            };
        }
    }
}