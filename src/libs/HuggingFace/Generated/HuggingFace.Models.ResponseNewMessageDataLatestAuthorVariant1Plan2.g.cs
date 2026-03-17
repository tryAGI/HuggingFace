
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan2
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan2 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan2.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan2.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan2.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan2.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}