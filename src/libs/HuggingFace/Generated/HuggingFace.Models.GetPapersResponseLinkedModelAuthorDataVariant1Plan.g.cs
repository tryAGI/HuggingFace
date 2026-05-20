
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAuthorDataVariant1Plan
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
    public static class GetPapersResponseLinkedModelAuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAuthorDataVariant1Plan value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAuthorDataVariant1Plan.Academia => "academia",
                GetPapersResponseLinkedModelAuthorDataVariant1Plan.Enterprise => "enterprise",
                GetPapersResponseLinkedModelAuthorDataVariant1Plan.Plus => "plus",
                GetPapersResponseLinkedModelAuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseLinkedModelAuthorDataVariant1Plan.Academia,
                "enterprise" => GetPapersResponseLinkedModelAuthorDataVariant1Plan.Enterprise,
                "plus" => GetPapersResponseLinkedModelAuthorDataVariant1Plan.Plus,
                "team" => GetPapersResponseLinkedModelAuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}