
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant1Plan3
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
    public static class ResponseNewMessageAuthorVariant1Plan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant1Plan3 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant1Plan3.Team => "team",
                ResponseNewMessageAuthorVariant1Plan3.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant1Plan3.Plus => "plus",
                ResponseNewMessageAuthorVariant1Plan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant1Plan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant1Plan3.Team,
                "enterprise" => ResponseNewMessageAuthorVariant1Plan3.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant1Plan3.Plus,
                "academia" => ResponseNewMessageAuthorVariant1Plan3.Academia,
                _ => null,
            };
        }
    }
}