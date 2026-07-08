
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTemplatesResponseTemplateSdk
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesTemplatesResponseTemplateSdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTemplatesResponseTemplateSdk value)
        {
            return value switch
            {
                GetSpacesTemplatesResponseTemplateSdk.Docker => "docker",
                GetSpacesTemplatesResponseTemplateSdk.Gradio => "gradio",
                GetSpacesTemplatesResponseTemplateSdk.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTemplatesResponseTemplateSdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => GetSpacesTemplatesResponseTemplateSdk.Docker,
                "gradio" => GetSpacesTemplatesResponseTemplateSdk.Gradio,
                "static" => GetSpacesTemplatesResponseTemplateSdk.Static,
                _ => null,
            };
        }
    }
}