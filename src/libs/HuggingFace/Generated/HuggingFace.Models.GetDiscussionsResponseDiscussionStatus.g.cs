
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseDiscussionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionStatus value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionStatus.Closed => "closed",
                GetDiscussionsResponseDiscussionStatus.Draft => "draft",
                GetDiscussionsResponseDiscussionStatus.Merged => "merged",
                GetDiscussionsResponseDiscussionStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetDiscussionsResponseDiscussionStatus.Closed,
                "draft" => GetDiscussionsResponseDiscussionStatus.Draft,
                "merged" => GetDiscussionsResponseDiscussionStatus.Merged,
                "open" => GetDiscussionsResponseDiscussionStatus.Open,
                _ => null,
            };
        }
    }
}