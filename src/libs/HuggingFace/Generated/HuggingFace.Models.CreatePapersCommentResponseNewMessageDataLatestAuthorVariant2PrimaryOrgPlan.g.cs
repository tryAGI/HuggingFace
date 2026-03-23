
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}