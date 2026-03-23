
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}