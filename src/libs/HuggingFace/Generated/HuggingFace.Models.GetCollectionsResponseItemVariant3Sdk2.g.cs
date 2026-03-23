
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3Sdk2
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
    public static class GetCollectionsResponseItemVariant3Sdk2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3Sdk2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3Sdk2.Docker => "docker",
                GetCollectionsResponseItemVariant3Sdk2.Gradio => "gradio",
                GetCollectionsResponseItemVariant3Sdk2.Static => "static",
                GetCollectionsResponseItemVariant3Sdk2.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3Sdk2? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetCollectionsResponseItemVariant3Sdk2.Docker,
                "gradio" => GetCollectionsResponseItemVariant3Sdk2.Gradio,
                "static" => GetCollectionsResponseItemVariant3Sdk2.Static,
                "streamlit" => GetCollectionsResponseItemVariant3Sdk2.Streamlit,
                _ => null,
            };
        }
    }
}