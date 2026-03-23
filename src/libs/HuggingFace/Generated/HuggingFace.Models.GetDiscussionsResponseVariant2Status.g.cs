
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2Status
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
    public static class GetDiscussionsResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2Status value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2Status.Closed => "closed",
                GetDiscussionsResponseVariant2Status.Draft => "draft",
                GetDiscussionsResponseVariant2Status.Merged => "merged",
                GetDiscussionsResponseVariant2Status.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetDiscussionsResponseVariant2Status.Closed,
                "draft" => GetDiscussionsResponseVariant2Status.Draft,
                "merged" => GetDiscussionsResponseVariant2Status.Merged,
                "open" => GetDiscussionsResponseVariant2Status.Open,
                _ => null,
            };
        }
    }
}