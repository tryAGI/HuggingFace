
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan
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
    public static class GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan value)
        {
            return value switch
            {
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Academia => "academia",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise => "enterprise",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Plus => "plus",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Academia,
                "enterprise" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise,
                "plus" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Plus,
                "team" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}