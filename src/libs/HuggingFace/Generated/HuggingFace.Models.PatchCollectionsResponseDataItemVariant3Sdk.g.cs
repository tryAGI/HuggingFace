
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3Sdk
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
    public static class PatchCollectionsResponseDataItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3Sdk value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3Sdk.Docker => "docker",
                PatchCollectionsResponseDataItemVariant3Sdk.Gradio => "gradio",
                PatchCollectionsResponseDataItemVariant3Sdk.Static => "static",
                PatchCollectionsResponseDataItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => PatchCollectionsResponseDataItemVariant3Sdk.Docker,
                "gradio" => PatchCollectionsResponseDataItemVariant3Sdk.Gradio,
                "static" => PatchCollectionsResponseDataItemVariant3Sdk.Static,
                "streamlit" => PatchCollectionsResponseDataItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}