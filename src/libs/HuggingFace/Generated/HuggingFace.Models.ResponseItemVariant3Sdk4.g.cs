
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Sdk4
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
    public static class ResponseItemVariant3Sdk4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Sdk4 value)
        {
            return value switch
            {
                ResponseItemVariant3Sdk4.Gradio => "gradio",
                ResponseItemVariant3Sdk4.Docker => "docker",
                ResponseItemVariant3Sdk4.Static => "static",
                ResponseItemVariant3Sdk4.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Sdk4? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseItemVariant3Sdk4.Gradio,
                "docker" => ResponseItemVariant3Sdk4.Docker,
                "static" => ResponseItemVariant3Sdk4.Static,
                "streamlit" => ResponseItemVariant3Sdk4.Streamlit,
                _ => null,
            };
        }
    }
}