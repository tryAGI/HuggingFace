
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant1Plan
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
    public static class ResponseAuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseAuthorDataVariant1Plan.Team => "team",
                ResponseAuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseAuthorDataVariant1Plan.Plus => "plus",
                ResponseAuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseAuthorDataVariant1Plan.Team,
                "enterprise" => ResponseAuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseAuthorDataVariant1Plan.Plus,
                "academia" => ResponseAuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}