
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: size
    /// </summary>
    public enum GetModelsLfsFilesSort
    {
        /// <summary>
        ///
        /// </summary>
        PushedAt,
        /// <summary>
        ///
        /// </summary>
        Size,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsLfsFilesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsLfsFilesSort value)
        {
            return value switch
            {
                GetModelsLfsFilesSort.PushedAt => "pushedAt",
                GetModelsLfsFilesSort.Size => "size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsLfsFilesSort? ToEnum(string value)
        {
            return value switch
            {
                "pushedAt" => GetModelsLfsFilesSort.PushedAt,
                "size" => GetModelsLfsFilesSort.Size,
                _ => null,
            };
        }
    }
}