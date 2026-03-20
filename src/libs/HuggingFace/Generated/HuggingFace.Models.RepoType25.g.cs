
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType25
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType25Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType25 value)
        {
            return value switch
            {
                RepoType25.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType25? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => RepoType25.Datasets,
                _ => null,
            };
        }
    }
}