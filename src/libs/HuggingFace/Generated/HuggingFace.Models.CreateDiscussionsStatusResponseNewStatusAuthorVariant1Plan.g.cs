
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan
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
    public static class CreateDiscussionsStatusResponseNewStatusAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Academia => "academia",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Enterprise => "enterprise",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Plus => "plus",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Academia,
                "enterprise" => CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Enterprise,
                "plus" => CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Plus,
                "team" => CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}