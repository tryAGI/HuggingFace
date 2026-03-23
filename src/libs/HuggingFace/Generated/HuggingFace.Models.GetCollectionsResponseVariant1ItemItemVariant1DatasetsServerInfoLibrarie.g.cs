
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie
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
    public static class GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "dask" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Dask,
                "datadesigner" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "distilabel" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "polars" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Polars,
                "webdataset" => GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}