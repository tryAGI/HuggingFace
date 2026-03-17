
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie
    {
        /// <summary>
        /// 
        /// </summary>
        Mlcroissant,
        /// <summary>
        /// 
        /// </summary>
        Webdataset,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Pandas,
        /// <summary>
        /// 
        /// </summary>
        Dask,
        /// <summary>
        /// 
        /// </summary>
        Distilabel,
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
        Argilla,
        /// <summary>
        /// 
        /// </summary>
        Polars,
        /// <summary>
        /// 
        /// </summary>
        Duckdb,
        /// <summary>
        /// 
        /// </summary>
        Datadesigner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Webdataset => "webdataset",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datasets => "datasets",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Pandas => "pandas",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Dask => "dask",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Distilabel => "distilabel",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Lance => "lance",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Argilla => "argilla",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Polars => "polars",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Duckdb => "duckdb",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Mlcroissant,
                "webdataset" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Webdataset,
                "datasets" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datasets,
                "pandas" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Pandas,
                "dask" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Dask,
                "distilabel" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Distilabel,
                "fiftyone" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Fiftyone,
                "lance" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Lance,
                "argilla" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Argilla,
                "polars" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Polars,
                "duckdb" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Duckdb,
                "datadesigner" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie.Datadesigner,
                _ => null,
            };
        }
    }
}