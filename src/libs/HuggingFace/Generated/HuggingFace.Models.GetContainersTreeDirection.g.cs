
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort direction. Defaults to `asc` for `path` and `desc` for `uploadedAt`.
    /// </summary>
    public enum GetContainersTreeDirection
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
    public static class GetContainersTreeDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersTreeDirection value)
        {
            return value switch
            {
                GetContainersTreeDirection.Asc => "asc",
                GetContainersTreeDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersTreeDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetContainersTreeDirection.Asc,
                "desc" => GetContainersTreeDirection.Desc,
                _ => null,
            };
        }
    }
}