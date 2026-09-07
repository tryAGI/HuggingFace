
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant2Arch2
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
    public static class CreateSettingsWebhooksRequestJobVariant2Arch2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant2Arch2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant2Arch2.Amd64 => "amd64",
                CreateSettingsWebhooksRequestJobVariant2Arch2.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant2Arch2? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateSettingsWebhooksRequestJobVariant2Arch2.Amd64,
                "arm64" => CreateSettingsWebhooksRequestJobVariant2Arch2.Arm64,
                _ => null,
            };
        }
    }
}