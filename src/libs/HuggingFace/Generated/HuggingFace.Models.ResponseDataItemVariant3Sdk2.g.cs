
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3Sdk2
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
    public static class ResponseDataItemVariant3Sdk2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3Sdk2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3Sdk2.Gradio => "gradio",
                ResponseDataItemVariant3Sdk2.Docker => "docker",
                ResponseDataItemVariant3Sdk2.Static => "static",
                ResponseDataItemVariant3Sdk2.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3Sdk2? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseDataItemVariant3Sdk2.Gradio,
                "docker" => ResponseDataItemVariant3Sdk2.Docker,
                "static" => ResponseDataItemVariant3Sdk2.Static,
                "streamlit" => ResponseDataItemVariant3Sdk2.Streamlit,
                _ => null,
            };
        }
    }
}