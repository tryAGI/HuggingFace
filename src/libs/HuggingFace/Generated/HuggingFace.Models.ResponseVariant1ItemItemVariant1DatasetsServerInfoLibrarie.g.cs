
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie
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
    public static class ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Mlcroissant => "mlcroissant",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Webdataset => "webdataset",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datasets => "datasets",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Pandas => "pandas",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Dask => "dask",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Distilabel => "distilabel",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Fiftyone => "fiftyone",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Lance => "lance",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Argilla => "argilla",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Polars => "polars",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Duckdb => "duckdb",
                ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datadesigner => "datadesigner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "mlcroissant" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Mlcroissant,
                "webdataset" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Webdataset,
                "datasets" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datasets,
                "pandas" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Pandas,
                "dask" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Dask,
                "distilabel" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Distilabel,
                "fiftyone" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Fiftyone,
                "lance" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Lance,
                "argilla" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Argilla,
                "polars" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Polars,
                "duckdb" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Duckdb,
                "datadesigner" => ResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie.Datadesigner,
                _ => null,
            };
        }
    }
}