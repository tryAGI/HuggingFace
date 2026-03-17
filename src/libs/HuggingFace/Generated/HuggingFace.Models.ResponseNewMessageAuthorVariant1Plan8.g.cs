
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant1Plan8
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
    public static class ResponseNewMessageAuthorVariant1Plan8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant1Plan8 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant1Plan8.Team => "team",
                ResponseNewMessageAuthorVariant1Plan8.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant1Plan8.Plus => "plus",
                ResponseNewMessageAuthorVariant1Plan8.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant1Plan8? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant1Plan8.Team,
                "enterprise" => ResponseNewMessageAuthorVariant1Plan8.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant1Plan8.Plus,
                "academia" => ResponseNewMessageAuthorVariant1Plan8.Academia,
                _ => null,
            };
        }
    }
}