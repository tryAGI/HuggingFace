
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        ViewerPartial,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Preview => "preview",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Preview,
                "viewer-partial" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.ViewerPartial,
                "viewer" => ResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Viewer,
                _ => null,
            };
        }
    }
}