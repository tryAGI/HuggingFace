
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestVariant4Sdk
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant4SdkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant4Sdk value)
        {
            return value switch
            {
                RequestVariant4Sdk.Gradio => "gradio",
                RequestVariant4Sdk.Docker => "docker",
                RequestVariant4Sdk.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant4Sdk? ToEnum(string value)
        {
            return value switch
            {
                "gradio" => RequestVariant4Sdk.Gradio,
                "docker" => RequestVariant4Sdk.Docker,
                "static" => RequestVariant4Sdk.Static,
                _ => null,
            };
        }
    }
}