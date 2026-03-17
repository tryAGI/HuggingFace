
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgPlan2
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
    public static class ResponseOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgPlan2 value)
        {
            return value switch
            {
                ResponseOrgPlan2.Team => "team",
                ResponseOrgPlan2.Enterprise => "enterprise",
                ResponseOrgPlan2.Plus => "plus",
                ResponseOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOrgPlan2.Team,
                "enterprise" => ResponseOrgPlan2.Enterprise,
                "plus" => ResponseOrgPlan2.Plus,
                "academia" => ResponseOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}