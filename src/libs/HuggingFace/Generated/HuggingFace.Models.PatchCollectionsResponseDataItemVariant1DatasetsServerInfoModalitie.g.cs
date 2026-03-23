
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie
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
    public static class PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Document => "document",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Image => "image",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Text => "text",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}