
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOauthUserinfoResponseOrgPlan
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
    public static class GetOauthUserinfoResponseOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseOrgPlan value)
        {
            return value switch
            {
                GetOauthUserinfoResponseOrgPlan.Academia => "academia",
                GetOauthUserinfoResponseOrgPlan.Enterprise => "enterprise",
                GetOauthUserinfoResponseOrgPlan.Plus => "plus",
                GetOauthUserinfoResponseOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetOauthUserinfoResponseOrgPlan.Academia,
                "enterprise" => GetOauthUserinfoResponseOrgPlan.Enterprise,
                "plus" => GetOauthUserinfoResponseOrgPlan.Plus,
                "team" => GetOauthUserinfoResponseOrgPlan.Team,
                _ => null,
            };
        }
    }
}