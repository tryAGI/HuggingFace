
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Sdk
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
    public static class ResponseItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Sdk value)
        {
            return value switch
            {
                ResponseItemVariant3Sdk.Gradio => "gradio",
                ResponseItemVariant3Sdk.Docker => "docker",
                ResponseItemVariant3Sdk.Static => "static",
                ResponseItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseItemVariant3Sdk.Gradio,
                "docker" => ResponseItemVariant3Sdk.Docker,
                "static" => ResponseItemVariant3Sdk.Static,
                "streamlit" => ResponseItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}