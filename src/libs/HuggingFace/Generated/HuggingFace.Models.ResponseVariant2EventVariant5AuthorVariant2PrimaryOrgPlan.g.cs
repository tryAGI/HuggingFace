
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan
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
    public static class ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}