
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoLibrarie3
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
    public static class ResponseItemVariant1DatasetsServerInfoLibrarie3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoLibrarie3 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Mlcroissant => "mlcroissant",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Datasets => "datasets",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Pandas => "pandas",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Dask => "dask",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Distilabel => "distilabel",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Fiftyone => "fiftyone",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Lance => "lance",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Argilla => "argilla",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Polars => "polars",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Duckdb => "duckdb",
                ResponseItemVariant1DatasetsServerInfoLibrarie3.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoLibrarie3? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Mlcroissant,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Webdataset,
                "datasets" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Datasets,
                "pandas" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Pandas,
                "dask" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Dask,
                "distilabel" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Distilabel,
                "fiftyone" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Fiftyone,
                "lance" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Lance,
                "argilla" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Argilla,
                "polars" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Polars,
                "duckdb" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Duckdb,
                "datadesigner" => ResponseItemVariant1DatasetsServerInfoLibrarie3.Datadesigner,
                _ => null,
            };
        }
    }
}