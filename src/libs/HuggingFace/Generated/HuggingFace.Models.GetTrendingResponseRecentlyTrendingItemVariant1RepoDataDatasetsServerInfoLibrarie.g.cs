
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Argilla => "argilla",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Dask => "dask",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datasets => "datasets",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Distilabel => "distilabel",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Duckdb => "duckdb",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Lance => "lance",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Pandas => "pandas",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Polars => "polars",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Argilla,
                "dask" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Dask,
                "datadesigner" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datasets,
                "distilabel" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Fiftyone,
                "lance" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Pandas,
                "polars" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Polars,
                "webdataset" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}