
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsExpand2
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
    public static class GetKernelsExpand2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsExpand2 value)
        {
            return value switch
            {
                GetKernelsExpand2.ArxivIds => "arxivIds",
                GetKernelsExpand2.Author => "author",
                GetKernelsExpand2.BuildMetadata => "buildMetadata",
                GetKernelsExpand2.CardData => "cardData",
                GetKernelsExpand2.CreatedAt => "createdAt",
                GetKernelsExpand2.Disabled => "disabled",
                GetKernelsExpand2.Downloads => "downloads",
                GetKernelsExpand2.DownloadsAllTime => "downloadsAllTime",
                GetKernelsExpand2.Files => "files",
                GetKernelsExpand2.Gated => "gated",
                GetKernelsExpand2.LastModified => "lastModified",
                GetKernelsExpand2.Likes => "likes",
                GetKernelsExpand2.Private => "private",
                GetKernelsExpand2.ResourceGroup => "resourceGroup",
                GetKernelsExpand2.Sha => "sha",
                GetKernelsExpand2.SupportedDriverFamilies => "supportedDriverFamilies",
                GetKernelsExpand2.Tags => "tags",
                GetKernelsExpand2.TrendingScore => "trendingScore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsExpand2? ToEnum(string value)
        {
            return value switch
            {
                "arxivIds" => GetKernelsExpand2.ArxivIds,
                "author" => GetKernelsExpand2.Author,
                "buildMetadata" => GetKernelsExpand2.BuildMetadata,
                "cardData" => GetKernelsExpand2.CardData,
                "createdAt" => GetKernelsExpand2.CreatedAt,
                "disabled" => GetKernelsExpand2.Disabled,
                "downloads" => GetKernelsExpand2.Downloads,
                "downloadsAllTime" => GetKernelsExpand2.DownloadsAllTime,
                "files" => GetKernelsExpand2.Files,
                "gated" => GetKernelsExpand2.Gated,
                "lastModified" => GetKernelsExpand2.LastModified,
                "likes" => GetKernelsExpand2.Likes,
                "private" => GetKernelsExpand2.Private,
                "resourceGroup" => GetKernelsExpand2.ResourceGroup,
                "sha" => GetKernelsExpand2.Sha,
                "supportedDriverFamilies" => GetKernelsExpand2.SupportedDriverFamilies,
                "tags" => GetKernelsExpand2.Tags,
                "trendingScore" => GetKernelsExpand2.TrendingScore,
                _ => null,
            };
        }
    }
}