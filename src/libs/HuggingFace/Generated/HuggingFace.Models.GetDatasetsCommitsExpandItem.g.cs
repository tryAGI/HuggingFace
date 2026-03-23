
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsCommitsExpandItem
    {
        /// <summary>
        /// 
        /// </summary>
        Formatted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsCommitsExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsCommitsExpandItem value)
        {
            return value switch
            {
                GetDatasetsCommitsExpandItem.Formatted => "formatted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsCommitsExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "formatted" => GetDatasetsCommitsExpandItem.Formatted,
                _ => null,
            };
        }
    }
}