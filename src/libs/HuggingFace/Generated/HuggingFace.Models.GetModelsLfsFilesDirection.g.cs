
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetModelsLfsFilesDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsLfsFilesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsLfsFilesDirection value)
        {
            return value switch
            {
                GetModelsLfsFilesDirection.Asc => "asc",
                GetModelsLfsFilesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsLfsFilesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetModelsLfsFilesDirection.Asc,
                "desc" => GetModelsLfsFilesDirection.Desc,
                _ => null,
            };
        }
    }
}