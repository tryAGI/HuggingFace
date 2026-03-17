
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Sdk3
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
    public static class ResponseItemVariant3Sdk3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Sdk3 value)
        {
            return value switch
            {
                ResponseItemVariant3Sdk3.Gradio => "gradio",
                ResponseItemVariant3Sdk3.Docker => "docker",
                ResponseItemVariant3Sdk3.Static => "static",
                ResponseItemVariant3Sdk3.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Sdk3? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseItemVariant3Sdk3.Gradio,
                "docker" => ResponseItemVariant3Sdk3.Docker,
                "static" => ResponseItemVariant3Sdk3.Static,
                "streamlit" => ResponseItemVariant3Sdk3.Streamlit,
                _ => null,
            };
        }
    }
}