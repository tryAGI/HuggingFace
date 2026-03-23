
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}