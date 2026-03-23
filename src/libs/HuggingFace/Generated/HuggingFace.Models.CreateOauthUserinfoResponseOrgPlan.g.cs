
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthUserinfoResponseOrgPlan
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
    public static class CreateOauthUserinfoResponseOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseOrgPlan value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseOrgPlan.Academia => "academia",
                CreateOauthUserinfoResponseOrgPlan.Enterprise => "enterprise",
                CreateOauthUserinfoResponseOrgPlan.Plus => "plus",
                CreateOauthUserinfoResponseOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateOauthUserinfoResponseOrgPlan.Academia,
                "enterprise" => CreateOauthUserinfoResponseOrgPlan.Enterprise,
                "plus" => CreateOauthUserinfoResponseOrgPlan.Plus,
                "team" => CreateOauthUserinfoResponseOrgPlan.Team,
                _ => null,
            };
        }
    }
}