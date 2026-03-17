
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan9
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan9 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan9.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan9.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan9.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan9.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan9? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan9.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan9.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan9.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan9.Academia,
                _ => null,
            };
        }
    }
}