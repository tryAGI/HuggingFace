
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetSpacesLfsFilesDirection
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
    public static class GetSpacesLfsFilesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLfsFilesDirection value)
        {
            return value switch
            {
                GetSpacesLfsFilesDirection.Asc => "asc",
                GetSpacesLfsFilesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLfsFilesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSpacesLfsFilesDirection.Asc,
                "desc" => GetSpacesLfsFilesDirection.Desc,
                _ => null,
            };
        }
    }
}