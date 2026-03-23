
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsResponseGatedEnum2
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
    public static class PutModelsSettingsResponseGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsResponseGatedEnum2 value)
        {
            return value switch
            {
                PutModelsSettingsResponseGatedEnum2.Auto => "auto",
                PutModelsSettingsResponseGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsResponseGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PutModelsSettingsResponseGatedEnum2.Auto,
                "manual" => PutModelsSettingsResponseGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}