
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1Status value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1Status.Closed => "closed",
                GetDiscussionsResponseVariant1Status.Draft => "draft",
                GetDiscussionsResponseVariant1Status.Merged => "merged",
                GetDiscussionsResponseVariant1Status.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetDiscussionsResponseVariant1Status.Closed,
                "draft" => GetDiscussionsResponseVariant1Status.Draft,
                "merged" => GetDiscussionsResponseVariant1Status.Merged,
                "open" => GetDiscussionsResponseVariant1Status.Open,
                _ => null,
            };
        }
    }
}