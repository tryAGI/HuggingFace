
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan
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
    public static class CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}