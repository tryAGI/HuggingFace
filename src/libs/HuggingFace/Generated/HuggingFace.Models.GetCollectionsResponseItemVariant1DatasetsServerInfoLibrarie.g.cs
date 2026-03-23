
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "dask" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Dask,
                "datadesigner" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "distilabel" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "polars" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Polars,
                "webdataset" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}