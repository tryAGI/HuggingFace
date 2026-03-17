
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoLibrarie5
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
    public static class ResponseItemVariant1DatasetsServerInfoLibrarie5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoLibrarie5 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Mlcroissant => "mlcroissant",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Datasets => "datasets",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Pandas => "pandas",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Dask => "dask",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Distilabel => "distilabel",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Fiftyone => "fiftyone",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Lance => "lance",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Argilla => "argilla",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Polars => "polars",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Duckdb => "duckdb",
                ResponseItemVariant1DatasetsServerInfoLibrarie5.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoLibrarie5? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Mlcroissant,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Webdataset,
                "datasets" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Datasets,
                "pandas" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Pandas,
                "dask" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Dask,
                "distilabel" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Distilabel,
                "fiftyone" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Fiftyone,
                "lance" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Lance,
                "argilla" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Argilla,
                "polars" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Polars,
                "duckdb" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Duckdb,
                "datadesigner" => ResponseItemVariant1DatasetsServerInfoLibrarie5.Datadesigner,
                _ => null,
            };
        }
    }
}