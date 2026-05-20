
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersFieldItem
    {
        /// <summary>
        /// 
        /// </summary>
        Comments,
        /// <summary>
        /// 
        /// </summary>
        SubmissionDeadline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersFieldItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersFieldItem value)
        {
            return value switch
            {
                GetPapersFieldItem.Comments => "comments",
                GetPapersFieldItem.SubmissionDeadline => "submissionDeadline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersFieldItem? ToEnum(string value)
        {
            return value switch
            {
                "comments" => GetPapersFieldItem.Comments,
                "submissionDeadline" => GetPapersFieldItem.SubmissionDeadline,
                _ => null,
            };
        }
    }
}