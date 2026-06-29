
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsExpandItem
    {
        /// <summary>
        /// 
        /// </summary>
        ArxivIds,
        /// <summary>
        /// 
        /// </summary>
        Author,
        /// <summary>
        /// 
        /// </summary>
        BuildMetadata,
        /// <summary>
        /// 
        /// </summary>
        CardData,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Downloads,
        /// <summary>
        /// 
        /// </summary>
        DownloadsAllTime,
        /// <summary>
        /// 
        /// </summary>
        Files,
        /// <summary>
        /// 
        /// </summary>
        Gated,
        /// <summary>
        /// 
        /// </summary>
        LastModified,
        /// <summary>
        /// 
        /// </summary>
        Likes,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroup,
        /// <summary>
        /// 
        /// </summary>
        Sha,
        /// <summary>
        /// 
        /// </summary>
        SupportedDriverFamilies,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        TrendingScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsExpandItem value)
        {
            return value switch
            {
                GetKernelsExpandItem.ArxivIds => "arxivIds",
                GetKernelsExpandItem.Author => "author",
                GetKernelsExpandItem.BuildMetadata => "buildMetadata",
                GetKernelsExpandItem.CardData => "cardData",
                GetKernelsExpandItem.CreatedAt => "createdAt",
                GetKernelsExpandItem.Disabled => "disabled",
                GetKernelsExpandItem.Downloads => "downloads",
                GetKernelsExpandItem.DownloadsAllTime => "downloadsAllTime",
                GetKernelsExpandItem.Files => "files",
                GetKernelsExpandItem.Gated => "gated",
                GetKernelsExpandItem.LastModified => "lastModified",
                GetKernelsExpandItem.Likes => "likes",
                GetKernelsExpandItem.Private => "private",
                GetKernelsExpandItem.ResourceGroup => "resourceGroup",
                GetKernelsExpandItem.Sha => "sha",
                GetKernelsExpandItem.SupportedDriverFamilies => "supportedDriverFamilies",
                GetKernelsExpandItem.Tags => "tags",
                GetKernelsExpandItem.TrendingScore => "trendingScore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "arxivIds" => GetKernelsExpandItem.ArxivIds,
                "author" => GetKernelsExpandItem.Author,
                "buildMetadata" => GetKernelsExpandItem.BuildMetadata,
                "cardData" => GetKernelsExpandItem.CardData,
                "createdAt" => GetKernelsExpandItem.CreatedAt,
                "disabled" => GetKernelsExpandItem.Disabled,
                "downloads" => GetKernelsExpandItem.Downloads,
                "downloadsAllTime" => GetKernelsExpandItem.DownloadsAllTime,
                "files" => GetKernelsExpandItem.Files,
                "gated" => GetKernelsExpandItem.Gated,
                "lastModified" => GetKernelsExpandItem.LastModified,
                "likes" => GetKernelsExpandItem.Likes,
                "private" => GetKernelsExpandItem.Private,
                "resourceGroup" => GetKernelsExpandItem.ResourceGroup,
                "sha" => GetKernelsExpandItem.Sha,
                "supportedDriverFamilies" => GetKernelsExpandItem.SupportedDriverFamilies,
                "tags" => GetKernelsExpandItem.Tags,
                "trendingScore" => GetKernelsExpandItem.TrendingScore,
                _ => null,
            };
        }
    }
}