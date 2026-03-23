
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2
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
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Argilla => "argilla",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Dask => "dask",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datadesigner => "datadesigner",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datasets => "datasets",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Distilabel => "distilabel",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Duckdb => "duckdb",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Fiftyone => "fiftyone",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Lance => "lance",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant => "mlcroissant",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Pandas => "pandas",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Polars => "polars",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Argilla,
                "dask" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Dask,
                "datadesigner" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datadesigner,
                "datasets" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datasets,
                "distilabel" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Distilabel,
                "duckdb" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Duckdb,
                "fiftyone" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Fiftyone,
                "lance" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Lance,
                "mlcroissant" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant,
                "pandas" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Pandas,
                "polars" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Polars,
                "webdataset" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2.Webdataset,
                _ => null,
            };
        }
    }
}