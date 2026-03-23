
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSqlConsoleEmbedRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSqlConsoleEmbedRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSqlConsoleEmbedRepoType value)
        {
            return value switch
            {
                CreateSqlConsoleEmbedRepoType.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSqlConsoleEmbedRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateSqlConsoleEmbedRepoType.Datasets,
                _ => null,
            };
        }
    }
}