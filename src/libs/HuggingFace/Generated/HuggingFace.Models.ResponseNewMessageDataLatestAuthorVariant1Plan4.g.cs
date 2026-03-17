
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan4
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan4 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan4.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan4.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan4.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan4.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan4.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan4.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan4.Academia,
                _ => null,
            };
        }
    }
}