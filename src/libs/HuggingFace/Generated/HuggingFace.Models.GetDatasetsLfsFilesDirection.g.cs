
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetDatasetsLfsFilesDirection
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
    public static class GetDatasetsLfsFilesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLfsFilesDirection value)
        {
            return value switch
            {
                GetDatasetsLfsFilesDirection.Asc => "asc",
                GetDatasetsLfsFilesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLfsFilesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetDatasetsLfsFilesDirection.Asc,
                "desc" => GetDatasetsLfsFilesDirection.Desc,
                _ => null,
            };
        }
    }
}