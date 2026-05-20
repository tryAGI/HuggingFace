
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersField2
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
    public static class GetPapersField2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersField2 value)
        {
            return value switch
            {
                GetPapersField2.Comments => "comments",
                GetPapersField2.SubmissionDeadline => "submissionDeadline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersField2? ToEnum(string value)
        {
            return value switch
            {
                "comments" => GetPapersField2.Comments,
                "submissionDeadline" => GetPapersField2.SubmissionDeadline,
                _ => null,
            };
        }
    }
}