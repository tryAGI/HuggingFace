
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk
    {
        /// <summary>
        /// 
        /// </summary>
        Docker,
        /// <summary>
        /// 
        /// </summary>
        Gradio,
        /// <summary>
        /// 
        /// </summary>
        Static,
        /// <summary>
        /// 
        /// </summary>
        Streamlit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Docker => "docker",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Gradio => "gradio",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Static => "static",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Docker,
                "gradio" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Gradio,
                "static" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Static,
                "streamlit" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk.Streamlit,
                _ => null,
            };
        }
    }
}