
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewStatusAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseNewStatusAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewStatusAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewStatusAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseNewStatusAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}