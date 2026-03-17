
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Merged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDiscussionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionStatus value)
        {
            return value switch
            {
                ResponseDiscussionStatus.Draft => "draft",
                ResponseDiscussionStatus.Open => "open",
                ResponseDiscussionStatus.Closed => "closed",
                ResponseDiscussionStatus.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseDiscussionStatus.Draft,
                "open" => ResponseDiscussionStatus.Open,
                "closed" => ResponseDiscussionStatus.Closed,
                "merged" => ResponseDiscussionStatus.Merged,
                _ => null,
            };
        }
    }
}