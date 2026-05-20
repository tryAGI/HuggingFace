
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentDataLatestAuthorVariant1Plan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPapersResponseCommentDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                GetPapersResponseCommentDataLatestAuthorVariant1Plan.Academia => "academia",
                GetPapersResponseCommentDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                GetPapersResponseCommentDataLatestAuthorVariant1Plan.Plus => "plus",
                GetPapersResponseCommentDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseCommentDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => GetPapersResponseCommentDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => GetPapersResponseCommentDataLatestAuthorVariant1Plan.Plus,
                "team" => GetPapersResponseCommentDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}