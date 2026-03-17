
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionAuthorVariant1Plan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDiscussionAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseDiscussionAuthorVariant1Plan.Team => "team",
                ResponseDiscussionAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseDiscussionAuthorVariant1Plan.Plus => "plus",
                ResponseDiscussionAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDiscussionAuthorVariant1Plan.Team,
                "enterprise" => ResponseDiscussionAuthorVariant1Plan.Enterprise,
                "plus" => ResponseDiscussionAuthorVariant1Plan.Plus,
                "academia" => ResponseDiscussionAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}