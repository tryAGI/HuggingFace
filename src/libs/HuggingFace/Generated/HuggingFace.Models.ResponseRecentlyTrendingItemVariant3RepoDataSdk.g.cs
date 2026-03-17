
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataSdk
    {
        /// <summary>
        /// 
        /// </summary>
        Gradio,
        /// <summary>
        /// 
        /// </summary>
        Docker,
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
    public static class ResponseRecentlyTrendingItemVariant3RepoDataSdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataSdk value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataSdk.Gradio => "gradio",
                ResponseRecentlyTrendingItemVariant3RepoDataSdk.Docker => "docker",
                ResponseRecentlyTrendingItemVariant3RepoDataSdk.Static => "static",
                ResponseRecentlyTrendingItemVariant3RepoDataSdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataSdk? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseRecentlyTrendingItemVariant3RepoDataSdk.Gradio,
                "docker" => ResponseRecentlyTrendingItemVariant3RepoDataSdk.Docker,
                "static" => ResponseRecentlyTrendingItemVariant3RepoDataSdk.Static,
                "streamlit" => ResponseRecentlyTrendingItemVariant3RepoDataSdk.Streamlit,
                _ => null,
            };
        }
    }
}