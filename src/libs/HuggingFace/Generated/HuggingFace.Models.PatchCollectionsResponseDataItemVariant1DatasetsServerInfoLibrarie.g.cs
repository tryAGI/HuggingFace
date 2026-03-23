
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie
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
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "dask" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Dask,
                "datadesigner" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "distilabel" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "polars" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Polars,
                "webdataset" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}