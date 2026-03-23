
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie
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
    public static class CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.x3d => "3d",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Audio => "audio",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Document => "document",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial => "geospatial",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Image => "image",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Tabular => "tabular",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Text => "text",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries => "timeseries",
                CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie? ToEnum(string value)
        {
            return value switch
            {
                "3d" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.x3d,
                "audio" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Audio,
                "document" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Document,
                "geospatial" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Geospatial,
                "image" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Image,
                "tabular" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Tabular,
                "text" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Text,
                "timeseries" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Timeseries,
                "video" => CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie.Video,
                _ => null,
            };
        }
    }
}