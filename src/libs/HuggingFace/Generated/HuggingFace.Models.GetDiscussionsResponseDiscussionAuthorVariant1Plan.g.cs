
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionAuthorVariant1Plan
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
    public static class GetDiscussionsResponseDiscussionAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionAuthorVariant1Plan value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionAuthorVariant1Plan.Academia => "academia",
                GetDiscussionsResponseDiscussionAuthorVariant1Plan.Enterprise => "enterprise",
                GetDiscussionsResponseDiscussionAuthorVariant1Plan.Plus => "plus",
                GetDiscussionsResponseDiscussionAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseDiscussionAuthorVariant1Plan.Academia,
                "enterprise" => GetDiscussionsResponseDiscussionAuthorVariant1Plan.Enterprise,
                "plus" => GetDiscussionsResponseDiscussionAuthorVariant1Plan.Plus,
                "team" => GetDiscussionsResponseDiscussionAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}