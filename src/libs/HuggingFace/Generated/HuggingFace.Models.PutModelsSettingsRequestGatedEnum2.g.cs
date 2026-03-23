
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsRequestGatedEnum2
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
    public static class PutModelsSettingsRequestGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsRequestGatedEnum2 value)
        {
            return value switch
            {
                PutModelsSettingsRequestGatedEnum2.Auto => "auto",
                PutModelsSettingsRequestGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsRequestGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutModelsSettingsRequestGatedEnum2.Auto,
                "manual" => PutModelsSettingsRequestGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}