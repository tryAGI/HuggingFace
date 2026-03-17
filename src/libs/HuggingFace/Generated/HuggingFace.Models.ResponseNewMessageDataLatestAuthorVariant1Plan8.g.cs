
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan8
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan8 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan8.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan8.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan8.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan8.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan8? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan8.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan8.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan8.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan8.Academia,
                _ => null,
            };
        }
    }
}