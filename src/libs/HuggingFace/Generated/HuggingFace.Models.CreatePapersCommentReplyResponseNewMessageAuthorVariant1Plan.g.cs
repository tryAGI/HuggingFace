
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan
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
    public static class CreatePapersCommentReplyResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}