
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}