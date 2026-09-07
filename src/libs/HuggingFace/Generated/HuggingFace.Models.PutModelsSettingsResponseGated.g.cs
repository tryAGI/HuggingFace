
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutModelsSettingsResponseGated
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
    public static class PutModelsSettingsResponseGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsResponseGated value)
        {
            return value switch
            {
                PutModelsSettingsResponseGated.Auto => "auto",
                PutModelsSettingsResponseGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsResponseGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutModelsSettingsResponseGated.Auto,
                "manual" => PutModelsSettingsResponseGated.Manual,
                _ => null,
            };
        }
    }
}