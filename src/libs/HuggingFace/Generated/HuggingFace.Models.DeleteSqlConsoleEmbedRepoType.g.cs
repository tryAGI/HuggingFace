
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSqlConsoleEmbedRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteSqlConsoleEmbedRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSqlConsoleEmbedRepoType value)
        {
            return value switch
            {
                DeleteSqlConsoleEmbedRepoType.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSqlConsoleEmbedRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => DeleteSqlConsoleEmbedRepoType.Datasets,
                _ => null,
            };
        }
    }
}