
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoLibrarie
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
    public static class ResponseDataItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "webdataset" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                "datasets" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "pandas" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "dask" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Dask,
                "distilabel" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "fiftyone" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Lance,
                "argilla" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "polars" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Polars,
                "duckdb" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "datadesigner" => ResponseDataItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                _ => null,
            };
        }
    }
}