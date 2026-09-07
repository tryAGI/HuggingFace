
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutDatasetsSettingsResponseGated
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
    public static class PutDatasetsSettingsResponseGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsResponseGated value)
        {
            return value switch
            {
                PutDatasetsSettingsResponseGated.Auto => "auto",
                PutDatasetsSettingsResponseGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsResponseGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutDatasetsSettingsResponseGated.Auto,
                "manual" => PutDatasetsSettingsResponseGated.Manual,
                _ => null,
            };
        }
    }
}