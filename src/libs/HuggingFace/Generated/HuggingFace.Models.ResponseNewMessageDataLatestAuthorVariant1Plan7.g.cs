
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant1Plan7
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
    public static class ResponseNewMessageDataLatestAuthorVariant1Plan7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant1Plan7 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant1Plan7.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant1Plan7.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant1Plan7.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant1Plan7.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant1Plan7? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant1Plan7.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant1Plan7.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant1Plan7.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant1Plan7.Academia,
                _ => null,
            };
        }
    }
}