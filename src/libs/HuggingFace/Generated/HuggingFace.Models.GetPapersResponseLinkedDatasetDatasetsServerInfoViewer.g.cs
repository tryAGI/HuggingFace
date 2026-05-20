
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedDatasetDatasetsServerInfoViewer
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
        /// <summary>
        /// 
        /// </summary>
        ViewerPartial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseLinkedDatasetDatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedDatasetDatasetsServerInfoViewer value)
        {
            return value switch
            {
                GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.Preview => "preview",
                GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.Viewer => "viewer",
                GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedDatasetDatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.Preview,
                "viewer" => GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.Viewer,
                "viewer-partial" => GetPapersResponseLinkedDatasetDatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}