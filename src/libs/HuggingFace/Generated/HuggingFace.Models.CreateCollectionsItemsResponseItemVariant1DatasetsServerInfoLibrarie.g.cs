
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie
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
    public static class CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "argilla" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "dask" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Dask,
                "datadesigner" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                "datasets" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "distilabel" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "duckdb" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "fiftyone" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Lance,
                "mlcroissant" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "pandas" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "polars" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Polars,
                "webdataset" => CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                _ => null,
            };
        }
    }
}