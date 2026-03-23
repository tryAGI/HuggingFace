
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksAction
    {
        /// <summary>
        /// 
        /// </summary>
        Disable,
        /// <summary>
        /// 
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsWebhooksActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksAction value)
        {
            return value switch
            {
                CreateSettingsWebhooksAction.Disable => "disable",
                CreateSettingsWebhooksAction.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksAction? ToEnum(string value)
        {
            return value switch
            {
                "disable" => CreateSettingsWebhooksAction.Disable,
                "enable" => CreateSettingsWebhooksAction.Enable,
                _ => null,
            };
        }
    }
}