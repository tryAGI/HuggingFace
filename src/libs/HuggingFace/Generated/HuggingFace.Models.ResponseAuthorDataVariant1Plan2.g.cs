
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant1Plan2
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
    public static class ResponseAuthorDataVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant1Plan2 value)
        {
            return value switch
            {
                ResponseAuthorDataVariant1Plan2.Team => "team",
                ResponseAuthorDataVariant1Plan2.Enterprise => "enterprise",
                ResponseAuthorDataVariant1Plan2.Plus => "plus",
                ResponseAuthorDataVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseAuthorDataVariant1Plan2.Team,
                "enterprise" => ResponseAuthorDataVariant1Plan2.Enterprise,
                "plus" => ResponseAuthorDataVariant1Plan2.Plus,
                "academia" => ResponseAuthorDataVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}