
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseOwnerVariant1Plan
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
    public static class CreateCollectionsResponseOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseOwnerVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsResponseOwnerVariant1Plan.Academia => "academia",
                CreateCollectionsResponseOwnerVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsResponseOwnerVariant1Plan.Plus => "plus",
                CreateCollectionsResponseOwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseOwnerVariant1Plan.Academia,
                "enterprise" => CreateCollectionsResponseOwnerVariant1Plan.Enterprise,
                "plus" => CreateCollectionsResponseOwnerVariant1Plan.Plus,
                "team" => CreateCollectionsResponseOwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}