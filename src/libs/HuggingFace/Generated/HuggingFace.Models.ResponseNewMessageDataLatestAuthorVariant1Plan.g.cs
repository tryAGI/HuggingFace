
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}