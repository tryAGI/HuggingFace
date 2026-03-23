
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3Sdk
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
    public static class GetCollectionsResponseItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3Sdk value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3Sdk.Docker => "docker",
                GetCollectionsResponseItemVariant3Sdk.Gradio => "gradio",
                GetCollectionsResponseItemVariant3Sdk.Static => "static",
                GetCollectionsResponseItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetCollectionsResponseItemVariant3Sdk.Docker,
                "gradio" => GetCollectionsResponseItemVariant3Sdk.Gradio,
                "static" => GetCollectionsResponseItemVariant3Sdk.Static,
                "streamlit" => GetCollectionsResponseItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}