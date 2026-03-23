
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant1Plan2
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
    public static class PatchCollectionsResponseDataOwnerVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant1Plan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant1Plan2.Academia => "academia",
                PatchCollectionsResponseDataOwnerVariant1Plan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataOwnerVariant1Plan2.Plus => "plus",
                PatchCollectionsResponseDataOwnerVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataOwnerVariant1Plan2.Academia,
                "enterprise" => PatchCollectionsResponseDataOwnerVariant1Plan2.Enterprise,
                "plus" => PatchCollectionsResponseDataOwnerVariant1Plan2.Plus,
                "team" => PatchCollectionsResponseDataOwnerVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}