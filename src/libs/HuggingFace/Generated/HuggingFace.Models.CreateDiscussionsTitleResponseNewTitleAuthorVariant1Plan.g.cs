
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan
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
    public static class CreateDiscussionsTitleResponseNewTitleAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Academia => "academia",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Enterprise => "enterprise",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Plus => "plus",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Academia,
                "enterprise" => CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Enterprise,
                "plus" => CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Plus,
                "team" => CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}