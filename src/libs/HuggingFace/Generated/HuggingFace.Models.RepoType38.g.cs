
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType38
    {
        /// <summary>
        /// 
        /// </summary>
        Kernels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType38Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType38 value)
        {
            return value switch
            {
                RepoType38.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType38? ToEnum(string value)
        {
            return value switch
            {
                "kernels" => RepoType38.Kernels,
                _ => null,
            };
        }
    }
}