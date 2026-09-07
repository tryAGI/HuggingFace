
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutSpacesSettingsRequestGated
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
    public static class PutSpacesSettingsRequestGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsRequestGated value)
        {
            return value switch
            {
                PutSpacesSettingsRequestGated.Auto => "auto",
                PutSpacesSettingsRequestGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsRequestGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutSpacesSettingsRequestGated.Auto,
                "manual" => PutSpacesSettingsRequestGated.Manual,
                _ => null,
            };
        }
    }
}