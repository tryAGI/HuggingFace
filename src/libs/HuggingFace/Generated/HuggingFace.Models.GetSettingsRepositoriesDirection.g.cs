
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort direction (default: desc)<br/>
    /// Default Value: desc
    /// </summary>
    public enum GetSettingsRepositoriesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// desc)
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsRepositoriesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsRepositoriesDirection value)
        {
            return value switch
            {
                GetSettingsRepositoriesDirection.Asc => "asc",
                GetSettingsRepositoriesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsRepositoriesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSettingsRepositoriesDirection.Asc,
                "desc" => GetSettingsRepositoriesDirection.Desc,
                _ => null,
            };
        }
    }
}