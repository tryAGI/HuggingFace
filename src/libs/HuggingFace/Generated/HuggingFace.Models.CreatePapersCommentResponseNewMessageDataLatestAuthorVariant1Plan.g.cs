
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}