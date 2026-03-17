
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType47
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType47Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType47 value)
        {
            return value switch
            {
                RepoType47.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType47? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => RepoType47.Datasets,
                _ => null,
            };
        }
    }
}