
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Preview => "preview",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Viewer => "viewer",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.ViewerPartial => "viewer-partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Preview,
                "viewer" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.Viewer,
                "viewer-partial" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer.ViewerPartial,
                _ => null,
            };
        }
    }
}