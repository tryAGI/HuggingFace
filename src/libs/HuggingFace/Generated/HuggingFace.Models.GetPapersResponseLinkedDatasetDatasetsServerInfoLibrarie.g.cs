
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie
    {
        /// <summary>
        /// 
        /// </summary>
        Argilla,
        /// <summary>
        /// 
        /// </summary>
        Dask,
        /// <summary>
        /// 
        /// </summary>
        Datadesigner,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Distilabel,
        /// <summary>
        /// 
        /// </summary>
        Duckdb,
        /// <summary>
        /// 
        /// </summary>
        Fiftyone,
        /// <summary>
        /// 
        /// </summary>
        Lance,
        /// <summary>
        /// 
        /// </summary>
        Mlcroissant,
        /// <summary>
        /// 
        /// </summary>
        Pandas,
        /// <summary>
        /// 
        /// </summary>
        Polars,
        /// <summary>
        /// 
        /// </summary>
        Webdataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Argilla => "argilla",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Dask => "dask",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Datasets => "datasets",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Distilabel => "distilabel",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Duckdb => "duckdb",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Lance => "lance",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Pandas => "pandas",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Polars => "polars",
                GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Argilla,
                "dask" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Dask,
                "datadesigner" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Datasets,
                "distilabel" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Fiftyone,
                "lance" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Pandas,
                "polars" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Polars,
                "webdataset" => GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}