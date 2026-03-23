
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan
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
    public static class CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}