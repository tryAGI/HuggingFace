
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchSqlConsoleEmbedRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchSqlConsoleEmbedRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchSqlConsoleEmbedRepoType value)
        {
            return value switch
            {
                PatchSqlConsoleEmbedRepoType.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchSqlConsoleEmbedRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => PatchSqlConsoleEmbedRepoType.Datasets,
                _ => null,
            };
        }
    }
}