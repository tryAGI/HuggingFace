
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutModelsSettingsResponseVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutModelsSettingsResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsResponseVisibility value)
        {
            return value switch
            {
                PutModelsSettingsResponseVisibility.Private => "private",
                PutModelsSettingsResponseVisibility.Protected => "protected",
                PutModelsSettingsResponseVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutModelsSettingsResponseVisibility.Private,
                "protected" => PutModelsSettingsResponseVisibility.Protected,
                "public" => PutModelsSettingsResponseVisibility.Public,
                _ => null,
            };
        }
    }
}