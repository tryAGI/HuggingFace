
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutDatasetsSettingsRequestGated
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
    public static class PutDatasetsSettingsRequestGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsRequestGated value)
        {
            return value switch
            {
                PutDatasetsSettingsRequestGated.Auto => "auto",
                PutDatasetsSettingsRequestGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsRequestGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutDatasetsSettingsRequestGated.Auto,
                "manual" => PutDatasetsSettingsRequestGated.Manual,
                _ => null,
            };
        }
    }
}