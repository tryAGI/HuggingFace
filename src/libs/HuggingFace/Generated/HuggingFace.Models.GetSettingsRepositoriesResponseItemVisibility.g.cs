
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsRepositoriesResponseItemVisibility
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
    public static class GetSettingsRepositoriesResponseItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsRepositoriesResponseItemVisibility value)
        {
            return value switch
            {
                GetSettingsRepositoriesResponseItemVisibility.Private => "private",
                GetSettingsRepositoriesResponseItemVisibility.Protected => "protected",
                GetSettingsRepositoriesResponseItemVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsRepositoriesResponseItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetSettingsRepositoriesResponseItemVisibility.Private,
                "protected" => GetSettingsRepositoriesResponseItemVisibility.Protected,
                "public" => GetSettingsRepositoriesResponseItemVisibility.Public,
                _ => null,
            };
        }
    }
}