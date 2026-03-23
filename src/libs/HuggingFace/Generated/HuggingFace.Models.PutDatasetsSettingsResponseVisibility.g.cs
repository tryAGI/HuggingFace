
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutDatasetsSettingsResponseVisibility
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
    public static class PutDatasetsSettingsResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsResponseVisibility value)
        {
            return value switch
            {
                PutDatasetsSettingsResponseVisibility.Private => "private",
                PutDatasetsSettingsResponseVisibility.Protected => "protected",
                PutDatasetsSettingsResponseVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutDatasetsSettingsResponseVisibility.Private,
                "protected" => PutDatasetsSettingsResponseVisibility.Protected,
                "public" => PutDatasetsSettingsResponseVisibility.Public,
                _ => null,
            };
        }
    }
}