
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3Sdk
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
    public static class CreateCollectionsItemsResponseItemVariant3SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3Sdk value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3Sdk.Docker => "docker",
                CreateCollectionsItemsResponseItemVariant3Sdk.Gradio => "gradio",
                CreateCollectionsItemsResponseItemVariant3Sdk.Static => "static",
                CreateCollectionsItemsResponseItemVariant3Sdk.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => CreateCollectionsItemsResponseItemVariant3Sdk.Docker,
                "gradio" => CreateCollectionsItemsResponseItemVariant3Sdk.Gradio,
                "static" => CreateCollectionsItemsResponseItemVariant3Sdk.Static,
                "streamlit" => CreateCollectionsItemsResponseItemVariant3Sdk.Streamlit,
                _ => null,
            };
        }
    }
}