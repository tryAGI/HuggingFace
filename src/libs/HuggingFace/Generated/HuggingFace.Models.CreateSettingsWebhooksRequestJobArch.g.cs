
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobArch
    {
        /// <summary>
        /// 
        /// </summary>
        Amd64,
        /// <summary>
        /// 
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsWebhooksRequestJobArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobArch value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobArch.Amd64 => "amd64",
                CreateSettingsWebhooksRequestJobArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateSettingsWebhooksRequestJobArch.Amd64,
                "arm64" => CreateSettingsWebhooksRequestJobArch.Arm64,
                _ => null,
            };
        }
    }
}