
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan
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
    public static class GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan value)
        {
            return value switch
            {
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Academia => "academia",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise => "enterprise",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Plus => "plus",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Academia,
                "enterprise" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise,
                "plus" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Plus,
                "team" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}