
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutSpacesSettingsResponseGated
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
    public static class PutSpacesSettingsResponseGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsResponseGated value)
        {
            return value switch
            {
                PutSpacesSettingsResponseGated.Auto => "auto",
                PutSpacesSettingsResponseGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsResponseGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutSpacesSettingsResponseGated.Auto,
                "manual" => PutSpacesSettingsResponseGated.Manual,
                _ => null,
            };
        }
    }
}