
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3Sdk
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
    public static class CreateCollectionsResponseItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3Sdk value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3Sdk.Docker => "docker",
                CreateCollectionsResponseItemVariant3Sdk.Gradio => "gradio",
                CreateCollectionsResponseItemVariant3Sdk.Static => "static",
                CreateCollectionsResponseItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => CreateCollectionsResponseItemVariant3Sdk.Docker,
                "gradio" => CreateCollectionsResponseItemVariant3Sdk.Gradio,
                "static" => CreateCollectionsResponseItemVariant3Sdk.Static,
                "streamlit" => CreateCollectionsResponseItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}