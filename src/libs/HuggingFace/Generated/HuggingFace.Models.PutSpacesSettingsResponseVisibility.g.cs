
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutSpacesSettingsResponseVisibility
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
    public static class PutSpacesSettingsResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsResponseVisibility value)
        {
            return value switch
            {
                PutSpacesSettingsResponseVisibility.Private => "private",
                PutSpacesSettingsResponseVisibility.Protected => "protected",
                PutSpacesSettingsResponseVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutSpacesSettingsResponseVisibility.Private,
                "protected" => PutSpacesSettingsResponseVisibility.Protected,
                "public" => PutSpacesSettingsResponseVisibility.Public,
                _ => null,
            };
        }
    }
}