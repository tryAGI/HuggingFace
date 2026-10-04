
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSqlConsoleEmbedHideRepoType
    {
        /// <summary>
        ///
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSqlConsoleEmbedHideRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSqlConsoleEmbedHideRepoType value)
        {
            return value switch
            {
                CreateSqlConsoleEmbedHideRepoType.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSqlConsoleEmbedHideRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateSqlConsoleEmbedHideRepoType.Datasets,
                _ => null,
            };
        }
    }
}