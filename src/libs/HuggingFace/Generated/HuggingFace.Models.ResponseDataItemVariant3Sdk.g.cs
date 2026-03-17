
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3Sdk
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
    public static class ResponseDataItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3Sdk value)
        {
            return value switch
            {
                ResponseDataItemVariant3Sdk.Gradio => "gradio",
                ResponseDataItemVariant3Sdk.Docker => "docker",
                ResponseDataItemVariant3Sdk.Static => "static",
                ResponseDataItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseDataItemVariant3Sdk.Gradio,
                "docker" => ResponseDataItemVariant3Sdk.Docker,
                "static" => ResponseDataItemVariant3Sdk.Static,
                "streamlit" => ResponseDataItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}