
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan3
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan3 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan3.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan3.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan3.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan3.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan3.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan3.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan3.Academia,
                _ => null,
            };
        }
    }
}