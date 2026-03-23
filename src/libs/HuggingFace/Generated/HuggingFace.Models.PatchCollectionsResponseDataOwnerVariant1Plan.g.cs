
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant1Plan
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
    public static class PatchCollectionsResponseDataOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant1Plan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant1Plan.Academia => "academia",
                PatchCollectionsResponseDataOwnerVariant1Plan.Enterprise => "enterprise",
                PatchCollectionsResponseDataOwnerVariant1Plan.Plus => "plus",
                PatchCollectionsResponseDataOwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataOwnerVariant1Plan.Academia,
                "enterprise" => PatchCollectionsResponseDataOwnerVariant1Plan.Enterprise,
                "plus" => PatchCollectionsResponseDataOwnerVariant1Plan.Plus,
                "team" => PatchCollectionsResponseDataOwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}