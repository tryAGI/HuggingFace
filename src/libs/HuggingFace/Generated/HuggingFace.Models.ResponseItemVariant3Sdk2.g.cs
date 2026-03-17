
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Sdk2
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
    public static class ResponseItemVariant3Sdk2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Sdk2 value)
        {
            return value switch
            {
                ResponseItemVariant3Sdk2.Gradio => "gradio",
                ResponseItemVariant3Sdk2.Docker => "docker",
                ResponseItemVariant3Sdk2.Static => "static",
                ResponseItemVariant3Sdk2.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Sdk2? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseItemVariant3Sdk2.Gradio,
                "docker" => ResponseItemVariant3Sdk2.Docker,
                "static" => ResponseItemVariant3Sdk2.Static,
                "streamlit" => ResponseItemVariant3Sdk2.Streamlit,
                _ => null,
            };
        }
    }
}