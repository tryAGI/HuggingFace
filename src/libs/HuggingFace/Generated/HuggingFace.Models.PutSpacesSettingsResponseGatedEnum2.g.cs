
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsResponseGatedEnum2
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
    public static class PutSpacesSettingsResponseGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsResponseGatedEnum2 value)
        {
            return value switch
            {
                PutSpacesSettingsResponseGatedEnum2.Auto => "auto",
                PutSpacesSettingsResponseGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsResponseGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutSpacesSettingsResponseGatedEnum2.Auto,
                "manual" => PutSpacesSettingsResponseGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}