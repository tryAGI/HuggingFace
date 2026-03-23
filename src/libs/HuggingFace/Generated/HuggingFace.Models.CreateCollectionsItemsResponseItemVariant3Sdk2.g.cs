
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3Sdk2
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
    public static class CreateCollectionsItemsResponseItemVariant3Sdk2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3Sdk2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3Sdk2.Docker => "docker",
                CreateCollectionsItemsResponseItemVariant3Sdk2.Gradio => "gradio",
                CreateCollectionsItemsResponseItemVariant3Sdk2.Static => "static",
                CreateCollectionsItemsResponseItemVariant3Sdk2.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3Sdk2? ToEnum(string value)
        {
            return value switch
            {
                "docker" => CreateCollectionsItemsResponseItemVariant3Sdk2.Docker,
                "gradio" => CreateCollectionsItemsResponseItemVariant3Sdk2.Gradio,
                "static" => CreateCollectionsItemsResponseItemVariant3Sdk2.Static,
                "streamlit" => CreateCollectionsItemsResponseItemVariant3Sdk2.Streamlit,
                _ => null,
            };
        }
    }
}