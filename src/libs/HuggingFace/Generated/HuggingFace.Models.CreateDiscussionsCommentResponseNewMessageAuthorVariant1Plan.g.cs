
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan
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
    public static class CreateDiscussionsCommentResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}