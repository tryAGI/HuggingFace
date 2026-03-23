
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTagsByTypeResponseItemType
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
    public static class GetDatasetsTagsByTypeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTagsByTypeResponseItemType value)
        {
            return value switch
            {
                GetDatasetsTagsByTypeResponseItemType.AnnotationsCreators => "annotations_creators",
                GetDatasetsTagsByTypeResponseItemType.Arxiv => "arxiv",
                GetDatasetsTagsByTypeResponseItemType.Benchmark => "benchmark",
                GetDatasetsTagsByTypeResponseItemType.Doi => "doi",
                GetDatasetsTagsByTypeResponseItemType.Format => "format",
                GetDatasetsTagsByTypeResponseItemType.Language => "language",
                GetDatasetsTagsByTypeResponseItemType.LanguageCreators => "language_creators",
                GetDatasetsTagsByTypeResponseItemType.Library => "library",
                GetDatasetsTagsByTypeResponseItemType.License => "license",
                GetDatasetsTagsByTypeResponseItemType.Modality => "modality",
                GetDatasetsTagsByTypeResponseItemType.Multilinguality => "multilinguality",
                GetDatasetsTagsByTypeResponseItemType.Other => "other",
                GetDatasetsTagsByTypeResponseItemType.Region => "region",
                GetDatasetsTagsByTypeResponseItemType.SizeCategories => "size_categories",
                GetDatasetsTagsByTypeResponseItemType.SourceDatasets => "source_datasets",
                GetDatasetsTagsByTypeResponseItemType.TaskCategories => "task_categories",
                GetDatasetsTagsByTypeResponseItemType.TaskIds => "task_ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTagsByTypeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "annotations_creators" => GetDatasetsTagsByTypeResponseItemType.AnnotationsCreators,
                "arxiv" => GetDatasetsTagsByTypeResponseItemType.Arxiv,
                "benchmark" => GetDatasetsTagsByTypeResponseItemType.Benchmark,
                "doi" => GetDatasetsTagsByTypeResponseItemType.Doi,
                "format" => GetDatasetsTagsByTypeResponseItemType.Format,
                "language" => GetDatasetsTagsByTypeResponseItemType.Language,
                "language_creators" => GetDatasetsTagsByTypeResponseItemType.LanguageCreators,
                "library" => GetDatasetsTagsByTypeResponseItemType.Library,
                "license" => GetDatasetsTagsByTypeResponseItemType.License,
                "modality" => GetDatasetsTagsByTypeResponseItemType.Modality,
                "multilinguality" => GetDatasetsTagsByTypeResponseItemType.Multilinguality,
                "other" => GetDatasetsTagsByTypeResponseItemType.Other,
                "region" => GetDatasetsTagsByTypeResponseItemType.Region,
                "size_categories" => GetDatasetsTagsByTypeResponseItemType.SizeCategories,
                "source_datasets" => GetDatasetsTagsByTypeResponseItemType.SourceDatasets,
                "task_categories" => GetDatasetsTagsByTypeResponseItemType.TaskCategories,
                "task_ids" => GetDatasetsTagsByTypeResponseItemType.TaskIds,
                _ => null,
            };
        }
    }
}