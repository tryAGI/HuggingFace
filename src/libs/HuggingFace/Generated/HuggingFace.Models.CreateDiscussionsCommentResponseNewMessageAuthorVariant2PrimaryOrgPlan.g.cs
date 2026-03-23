
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}