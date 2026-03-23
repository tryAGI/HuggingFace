
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2
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
    public static class GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla => "argilla",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Dask => "dask",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner => "datadesigner",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets => "datasets",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel => "distilabel",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb => "duckdb",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone => "fiftyone",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Lance => "lance",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant => "mlcroissant",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas => "pandas",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Polars => "polars",
                GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla,
                "dask" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Dask,
                "datadesigner" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner,
                "datasets" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets,
                "distilabel" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel,
                "duckdb" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb,
                "fiftyone" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone,
                "lance" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Lance,
                "mlcroissant" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant,
                "pandas" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas,
                "polars" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Polars,
                "webdataset" => GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset,
                _ => null,
            };
        }
    }
}