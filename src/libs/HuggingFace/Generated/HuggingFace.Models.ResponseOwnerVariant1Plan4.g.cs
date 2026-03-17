
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant1Plan4
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
    public static class ResponseOwnerVariant1Plan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant1Plan4 value)
        {
            return value switch
            {
                ResponseOwnerVariant1Plan4.Team => "team",
                ResponseOwnerVariant1Plan4.Enterprise => "enterprise",
                ResponseOwnerVariant1Plan4.Plus => "plus",
                ResponseOwnerVariant1Plan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant1Plan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant1Plan4.Team,
                "enterprise" => ResponseOwnerVariant1Plan4.Enterprise,
                "plus" => ResponseOwnerVariant1Plan4.Plus,
                "academia" => ResponseOwnerVariant1Plan4.Academia,
                _ => null,
            };
        }
    }
}