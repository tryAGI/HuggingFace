
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3Sdk2
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
    public static class PatchCollectionsResponseDataItemVariant3Sdk2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3Sdk2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3Sdk2.Docker => "docker",
                PatchCollectionsResponseDataItemVariant3Sdk2.Gradio => "gradio",
                PatchCollectionsResponseDataItemVariant3Sdk2.Static => "static",
                PatchCollectionsResponseDataItemVariant3Sdk2.Streamlit => "streamlit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3Sdk2? ToEnum(string value)
        {
            return value switch
            {
                "docker" => PatchCollectionsResponseDataItemVariant3Sdk2.Docker,
                "gradio" => PatchCollectionsResponseDataItemVariant3Sdk2.Gradio,
                "static" => PatchCollectionsResponseDataItemVariant3Sdk2.Static,
                "streamlit" => PatchCollectionsResponseDataItemVariant3Sdk2.Streamlit,
                _ => null,
            };
        }
    }
}