
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsRequestGatedEnum2
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
    public static class PutSpacesSettingsRequestGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsRequestGatedEnum2 value)
        {
            return value switch
            {
                PutSpacesSettingsRequestGatedEnum2.Auto => "auto",
                PutSpacesSettingsRequestGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsRequestGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutSpacesSettingsRequestGatedEnum2.Auto,
                "manual" => PutSpacesSettingsRequestGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}