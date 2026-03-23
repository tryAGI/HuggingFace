
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReposCreateRequestVariant4Sdk
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
    public static class CreateReposCreateRequestVariant4SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant4Sdk value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant4Sdk.Docker => "docker",
                CreateReposCreateRequestVariant4Sdk.Gradio => "gradio",
                CreateReposCreateRequestVariant4Sdk.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant4Sdk? ToEnum(string value)
        {
            return value switch
            {
                "docker" => CreateReposCreateRequestVariant4Sdk.Docker,
                "gradio" => CreateReposCreateRequestVariant4Sdk.Gradio,
                "static" => CreateReposCreateRequestVariant4Sdk.Static,
                _ => null,
            };
        }
    }
}