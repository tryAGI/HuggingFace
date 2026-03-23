
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutModelsSettingsRequestVisibility
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
    public static class PutModelsSettingsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsRequestVisibility value)
        {
            return value switch
            {
                PutModelsSettingsRequestVisibility.Private => "private",
                PutModelsSettingsRequestVisibility.Protected => "protected",
                PutModelsSettingsRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutModelsSettingsRequestVisibility.Private,
                "protected" => PutModelsSettingsRequestVisibility.Protected,
                "public" => PutModelsSettingsRequestVisibility.Public,
                _ => null,
            };
        }
    }
}