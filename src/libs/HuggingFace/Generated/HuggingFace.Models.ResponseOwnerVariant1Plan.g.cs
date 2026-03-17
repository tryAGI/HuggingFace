
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant1Plan
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
    public static class ResponseOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant1Plan value)
        {
            return value switch
            {
                ResponseOwnerVariant1Plan.Team => "team",
                ResponseOwnerVariant1Plan.Enterprise => "enterprise",
                ResponseOwnerVariant1Plan.Plus => "plus",
                ResponseOwnerVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant1Plan.Team,
                "enterprise" => ResponseOwnerVariant1Plan.Enterprise,
                "plus" => ResponseOwnerVariant1Plan.Plus,
                "academia" => ResponseOwnerVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}