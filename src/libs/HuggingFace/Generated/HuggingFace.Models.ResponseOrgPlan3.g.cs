
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgPlan3
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
    public static class ResponseOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgPlan3 value)
        {
            return value switch
            {
                ResponseOrgPlan3.Team => "team",
                ResponseOrgPlan3.Enterprise => "enterprise",
                ResponseOrgPlan3.Plus => "plus",
                ResponseOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOrgPlan3.Team,
                "enterprise" => ResponseOrgPlan3.Enterprise,
                "plus" => ResponseOrgPlan3.Plus,
                "academia" => ResponseOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}