
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3Sdk
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
    public static class ResponseVariant1ItemItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3Sdk value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3Sdk.Gradio => "gradio",
                ResponseVariant1ItemItemVariant3Sdk.Docker => "docker",
                ResponseVariant1ItemItemVariant3Sdk.Static => "static",
                ResponseVariant1ItemItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => ResponseVariant1ItemItemVariant3Sdk.Gradio,
                "docker" => ResponseVariant1ItemItemVariant3Sdk.Docker,
                "static" => ResponseVariant1ItemItemVariant3Sdk.Static,
                "streamlit" => ResponseVariant1ItemItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}