
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3Sdk
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
    public static class GetCollectionsResponseVariant1ItemItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3Sdk value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3Sdk.Docker => "docker",
                GetCollectionsResponseVariant1ItemItemVariant3Sdk.Gradio => "gradio",
                GetCollectionsResponseVariant1ItemItemVariant3Sdk.Static => "static",
                GetCollectionsResponseVariant1ItemItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetCollectionsResponseVariant1ItemItemVariant3Sdk.Docker,
                "gradio" => GetCollectionsResponseVariant1ItemItemVariant3Sdk.Gradio,
                "static" => GetCollectionsResponseVariant1ItemItemVariant3Sdk.Static,
                "streamlit" => GetCollectionsResponseVariant1ItemItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}