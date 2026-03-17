
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1DatasetsServerInfoLibrarie2
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
    public static class ResponseDataItemVariant1DatasetsServerInfoLibrarie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1DatasetsServerInfoLibrarie2 value)
        {
            return value switch
            {
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant => "mlcroissant",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Webdataset => "webdataset",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datasets => "datasets",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Pandas => "pandas",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Dask => "dask",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Distilabel => "distilabel",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Fiftyone => "fiftyone",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Lance => "lance",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Argilla => "argilla",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Polars => "polars",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Duckdb => "duckdb",
                ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1DatasetsServerInfoLibrarie2? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Mlcroissant,
                "webdataset" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Webdataset,
                "datasets" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datasets,
                "pandas" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Pandas,
                "dask" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Dask,
                "distilabel" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Distilabel,
                "fiftyone" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Fiftyone,
                "lance" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Lance,
                "argilla" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Argilla,
                "polars" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Polars,
                "duckdb" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Duckdb,
                "datadesigner" => ResponseDataItemVariant1DatasetsServerInfoLibrarie2.Datadesigner,
                _ => null,
            };
        }
    }
}