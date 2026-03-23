
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetTrendingType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingType value)
        {
            return value switch
            {
                GetTrendingType.All => "all",
                GetTrendingType.Dataset => "dataset",
                GetTrendingType.Model => "model",
                GetTrendingType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetTrendingType.All,
                "dataset" => GetTrendingType.Dataset,
                "model" => GetTrendingType.Model,
                "space" => GetTrendingType.Space,
                _ => null,
            };
        }
    }
}