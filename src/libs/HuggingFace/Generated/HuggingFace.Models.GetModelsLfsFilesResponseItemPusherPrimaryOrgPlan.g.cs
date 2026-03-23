
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan
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
    public static class GetModelsLfsFilesResponseItemPusherPrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan value)
        {
            return value switch
            {
                GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Academia => "academia",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise => "enterprise",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Plus => "plus",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Academia,
                "enterprise" => GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Enterprise,
                "plus" => GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Plus,
                "team" => GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}