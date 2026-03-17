
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1DatasetsServerInfoLibrarie
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
    public static class ResponseItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                ResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                ResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "webdataset" => ResponseItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                "datasets" => ResponseItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "pandas" => ResponseItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "dask" => ResponseItemVariant1DatasetsServerInfoLibrarie.Dask,
                "distilabel" => ResponseItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "fiftyone" => ResponseItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => ResponseItemVariant1DatasetsServerInfoLibrarie.Lance,
                "argilla" => ResponseItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "polars" => ResponseItemVariant1DatasetsServerInfoLibrarie.Polars,
                "duckdb" => ResponseItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "datadesigner" => ResponseItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                _ => null,
            };
        }
    }
}