
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType48
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType48Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType48 value)
        {
            return value switch
            {
                RepoType48.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType48? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => RepoType48.Datasets,
                _ => null,
            };
        }
    }
}