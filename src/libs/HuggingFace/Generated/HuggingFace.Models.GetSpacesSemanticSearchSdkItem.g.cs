
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSpacesSemanticSearchSdkItem
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
    public static class GetSpacesSemanticSearchSdkItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesSemanticSearchSdkItem value)
        {
            return value switch
            {
                GetSpacesSemanticSearchSdkItem.Docker => "docker",
                GetSpacesSemanticSearchSdkItem.Gradio => "gradio",
                GetSpacesSemanticSearchSdkItem.Static => "static",
                GetSpacesSemanticSearchSdkItem.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesSemanticSearchSdkItem? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetSpacesSemanticSearchSdkItem.Docker,
                "gradio" => GetSpacesSemanticSearchSdkItem.Gradio,
                "static" => GetSpacesSemanticSearchSdkItem.Static,
                "streamlit" => GetSpacesSemanticSearchSdkItem.Streamlit,
                _ => null,
            };
        }
    }
}