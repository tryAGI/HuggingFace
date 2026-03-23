
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}