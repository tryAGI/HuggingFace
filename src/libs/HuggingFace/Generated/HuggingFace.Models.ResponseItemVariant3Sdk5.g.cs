
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Sdk5
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
    public static class ResponseItemVariant3Sdk5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Sdk5 value)
        {
            return value switch
            {
                ResponseItemVariant3Sdk5.Gradio => "gradio",
                ResponseItemVariant3Sdk5.Docker => "docker",
                ResponseItemVariant3Sdk5.Static => "static",
                ResponseItemVariant3Sdk5.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Sdk5? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseItemVariant3Sdk5.Gradio,
                "docker" => ResponseItemVariant3Sdk5.Docker,
                "static" => ResponseItemVariant3Sdk5.Static,
                "streamlit" => ResponseItemVariant3Sdk5.Streamlit,
                _ => null,
            };
        }
    }
}