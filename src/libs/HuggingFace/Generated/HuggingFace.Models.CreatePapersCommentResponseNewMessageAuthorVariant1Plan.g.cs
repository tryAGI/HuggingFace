
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageAuthorVariant1Plan
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
    public static class CreatePapersCommentResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreatePapersCommentResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}