
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsResponseGatedEnum2
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
    public static class PutDatasetsSettingsResponseGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsResponseGatedEnum2 value)
        {
            return value switch
            {
                PutDatasetsSettingsResponseGatedEnum2.Auto => "auto",
                PutDatasetsSettingsResponseGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsResponseGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutDatasetsSettingsResponseGatedEnum2.Auto,
                "manual" => PutDatasetsSettingsResponseGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}