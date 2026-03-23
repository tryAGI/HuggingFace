
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2
    {
        /// <summary>
        /// 
        /// </summary>
        x3d,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Geospatial,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Tabular,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Timeseries,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.x3d => "3d",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Audio => "audio",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Document => "document",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Geospatial => "geospatial",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Image => "image",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Tabular => "tabular",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Text => "text",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Timeseries => "timeseries",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2? ToEnum(string value)
        {
            return value switch
            {
                "3d" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.x3d,
                "audio" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Audio,
                "document" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Document,
                "geospatial" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Geospatial,
                "image" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Image,
                "tabular" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Tabular,
                "text" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Text,
                "timeseries" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Timeseries,
                "video" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2.Video,
                _ => null,
            };
        }
    }
}