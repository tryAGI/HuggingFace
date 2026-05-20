
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentAuthorVariant1Plan
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
    public static class GetPapersResponseCommentAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentAuthorVariant1Plan value)
        {
            return value switch
            {
                GetPapersResponseCommentAuthorVariant1Plan.Academia => "academia",
                GetPapersResponseCommentAuthorVariant1Plan.Enterprise => "enterprise",
                GetPapersResponseCommentAuthorVariant1Plan.Plus => "plus",
                GetPapersResponseCommentAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseCommentAuthorVariant1Plan.Academia,
                "enterprise" => GetPapersResponseCommentAuthorVariant1Plan.Enterprise,
                "plus" => GetPapersResponseCommentAuthorVariant1Plan.Plus,
                "team" => GetPapersResponseCommentAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}