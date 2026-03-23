
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum PutSpacesSettingsRequestVisibility
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
    public static class PutSpacesSettingsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsRequestVisibility value)
        {
            return value switch
            {
                PutSpacesSettingsRequestVisibility.Private => "private",
                PutSpacesSettingsRequestVisibility.Protected => "protected",
                PutSpacesSettingsRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PutSpacesSettingsRequestVisibility.Private,
                "protected" => PutSpacesSettingsRequestVisibility.Protected,
                "public" => PutSpacesSettingsRequestVisibility.Public,
                _ => null,
            };
        }
    }
}