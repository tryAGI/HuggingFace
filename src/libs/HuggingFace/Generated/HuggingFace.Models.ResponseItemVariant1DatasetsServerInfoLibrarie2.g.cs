
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoLibrarie2
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
    public static class ResponseItemVariant1DatasetsServerInfoLibrarie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoLibrarie2 value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant => "mlcroissant",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets => "datasets",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas => "pandas",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Dask => "dask",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel => "distilabel",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone => "fiftyone",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Lance => "lance",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla => "argilla",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Polars => "polars",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb => "duckdb",
                ResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoLibrarie2? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Webdataset,
                "datasets" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Datasets,
                "pandas" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Pandas,
                "dask" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Dask,
                "distilabel" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Distilabel,
                "fiftyone" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Fiftyone,
                "lance" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Lance,
                "argilla" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Argilla,
                "polars" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Polars,
                "duckdb" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Duckdb,
                "datadesigner" => ResponseItemVariant1DatasetsServerInfoLibrarie2.Datadesigner,
                _ => null,
            };
        }
    }
}