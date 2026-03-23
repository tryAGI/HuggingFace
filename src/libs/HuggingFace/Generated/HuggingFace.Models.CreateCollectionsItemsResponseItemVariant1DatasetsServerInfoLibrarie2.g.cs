
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla => "argilla",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Dask => "dask",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner => "datadesigner",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets => "datasets",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel => "distilabel",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb => "duckdb",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone => "fiftyone",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Lance => "lance",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant => "mlcroissant",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas => "pandas",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Polars => "polars",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla,
                "dask" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Dask,
                "datadesigner" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner,
                "datasets" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets,
                "distilabel" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel,
                "duckdb" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb,
                "fiftyone" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone,
                "lance" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Lance,
                "mlcroissant" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant,
                "pandas" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas,
                "polars" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Polars,
                "webdataset" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset,
                _ => null,
            };
        }
    }
}