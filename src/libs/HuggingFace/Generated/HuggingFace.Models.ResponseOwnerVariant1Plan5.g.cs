
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant1Plan5
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
    public static class ResponseOwnerVariant1Plan5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant1Plan5 value)
        {
            return value switch
            {
                ResponseOwnerVariant1Plan5.Team => "team",
                ResponseOwnerVariant1Plan5.Enterprise => "enterprise",
                ResponseOwnerVariant1Plan5.Plus => "plus",
                ResponseOwnerVariant1Plan5.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant1Plan5? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant1Plan5.Team,
                "enterprise" => ResponseOwnerVariant1Plan5.Enterprise,
                "plus" => ResponseOwnerVariant1Plan5.Plus,
                "academia" => ResponseOwnerVariant1Plan5.Academia,
                _ => null,
            };
        }
    }
}