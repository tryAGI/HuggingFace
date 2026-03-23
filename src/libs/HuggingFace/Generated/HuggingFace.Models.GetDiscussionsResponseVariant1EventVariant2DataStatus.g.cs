
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1EventVariant2DataStatus
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
    public static class GetDiscussionsResponseVariant1EventVariant2DataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1EventVariant2DataStatus value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1EventVariant2DataStatus.Closed => "closed",
                GetDiscussionsResponseVariant1EventVariant2DataStatus.Draft => "draft",
                GetDiscussionsResponseVariant1EventVariant2DataStatus.Merged => "merged",
                GetDiscussionsResponseVariant1EventVariant2DataStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1EventVariant2DataStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetDiscussionsResponseVariant1EventVariant2DataStatus.Closed,
                "draft" => GetDiscussionsResponseVariant1EventVariant2DataStatus.Draft,
                "merged" => GetDiscussionsResponseVariant1EventVariant2DataStatus.Merged,
                "open" => GetDiscussionsResponseVariant1EventVariant2DataStatus.Open,
                _ => null,
            };
        }
    }
}