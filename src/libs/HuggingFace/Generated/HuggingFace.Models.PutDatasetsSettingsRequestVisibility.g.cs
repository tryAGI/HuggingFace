
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutDatasetsSettingsRequestVisibility
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
    public static class PutDatasetsSettingsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsRequestVisibility value)
        {
            return value switch
            {
                PutDatasetsSettingsRequestVisibility.Private => "private",
                PutDatasetsSettingsRequestVisibility.Protected => "protected",
                PutDatasetsSettingsRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutDatasetsSettingsRequestVisibility.Private,
                "protected" => PutDatasetsSettingsRequestVisibility.Protected,
                "public" => PutDatasetsSettingsRequestVisibility.Public,
                _ => null,
            };
        }
    }
}