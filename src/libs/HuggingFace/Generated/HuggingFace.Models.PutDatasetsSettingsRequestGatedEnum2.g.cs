
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsRequestGatedEnum2
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
    public static class PutDatasetsSettingsRequestGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsRequestGatedEnum2 value)
        {
            return value switch
            {
                PutDatasetsSettingsRequestGatedEnum2.Auto => "auto",
                PutDatasetsSettingsRequestGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsRequestGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutDatasetsSettingsRequestGatedEnum2.Auto,
                "manual" => PutDatasetsSettingsRequestGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}