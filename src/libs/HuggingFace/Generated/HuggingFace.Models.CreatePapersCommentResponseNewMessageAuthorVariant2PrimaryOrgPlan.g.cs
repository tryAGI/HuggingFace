
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}