
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan
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
    public static class GetDiscussionsResponseVariant2EventVariant4AuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Academia => "academia",
                GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Enterprise => "enterprise",
                GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Plus => "plus",
                GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Academia,
                "enterprise" => GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Enterprise,
                "plus" => GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Plus,
                "team" => GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}