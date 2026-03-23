
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie
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
    public static class CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "dask" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Dask,
                "datadesigner" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "distilabel" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "polars" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Polars,
                "webdataset" => CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}