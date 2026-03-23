
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}