
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan
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
    public static class PatchCollectionsResponseDataItemVariant3AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Academia => "academia",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Plus => "plus",
                PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Plus,
                "team" => PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}