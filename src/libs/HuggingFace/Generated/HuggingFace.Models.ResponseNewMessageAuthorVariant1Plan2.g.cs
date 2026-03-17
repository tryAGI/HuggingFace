
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant1Plan2
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
    public static class ResponseNewMessageAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant1Plan2 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant1Plan2.Team => "team",
                ResponseNewMessageAuthorVariant1Plan2.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant1Plan2.Plus => "plus",
                ResponseNewMessageAuthorVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant1Plan2.Team,
                "enterprise" => ResponseNewMessageAuthorVariant1Plan2.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant1Plan2.Plus,
                "academia" => ResponseNewMessageAuthorVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}