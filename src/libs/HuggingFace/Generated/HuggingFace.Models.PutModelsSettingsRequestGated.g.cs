
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutModelsSettingsRequestGated
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutModelsSettingsRequestGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsRequestGated value)
        {
            return value switch
            {
                PutModelsSettingsRequestGated.Auto => "auto",
                PutModelsSettingsRequestGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsRequestGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutModelsSettingsRequestGated.Auto,
                "manual" => PutModelsSettingsRequestGated.Manual,
                _ => null,
            };
        }
    }
}