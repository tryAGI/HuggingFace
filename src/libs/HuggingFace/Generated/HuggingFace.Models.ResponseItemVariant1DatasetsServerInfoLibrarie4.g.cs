
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoLibrarie4
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
    public static class ResponseItemVariant1DatasetsServerInfoLibrarie4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoLibrarie4 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Mlcroissant => "mlcroissant",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Datasets => "datasets",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Pandas => "pandas",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Dask => "dask",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Distilabel => "distilabel",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Fiftyone => "fiftyone",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Lance => "lance",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Argilla => "argilla",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Polars => "polars",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Duckdb => "duckdb",
                ResponseItemVariant1DatasetsServerInfoLibrarie4.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoLibrarie4? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Mlcroissant,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Webdataset,
                "datasets" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Datasets,
                "pandas" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Pandas,
                "dask" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Dask,
                "distilabel" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Distilabel,
                "fiftyone" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Fiftyone,
                "lance" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Lance,
                "argilla" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Argilla,
                "polars" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Polars,
                "duckdb" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Duckdb,
                "datadesigner" => ResponseItemVariant1DatasetsServerInfoLibrarie4.Datadesigner,
                _ => null,
            };
        }
    }
}