
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
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
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWhoamiV2ResponseOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseOrgPlan value)
        {
            return value switch
            {
                GetWhoamiV2ResponseOrgPlan.Academia => "academia",
                GetWhoamiV2ResponseOrgPlan.Enterprise => "enterprise",
                GetWhoamiV2ResponseOrgPlan.Plus => "plus",
                GetWhoamiV2ResponseOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetWhoamiV2ResponseOrgPlan.Academia,
                "enterprise" => GetWhoamiV2ResponseOrgPlan.Enterprise,
                "plus" => GetWhoamiV2ResponseOrgPlan.Plus,
                "team" => GetWhoamiV2ResponseOrgPlan.Team,
                _ => null,
            };
        }
    }
}