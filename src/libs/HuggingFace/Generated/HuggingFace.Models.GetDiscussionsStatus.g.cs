
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetDiscussionsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsStatus value)
        {
            return value switch
            {
                GetDiscussionsStatus.All => "all",
                GetDiscussionsStatus.Closed => "closed",
                GetDiscussionsStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetDiscussionsStatus.All,
                "closed" => GetDiscussionsStatus.Closed,
                "open" => GetDiscussionsStatus.Open,
                _ => null,
            };
        }
    }
}