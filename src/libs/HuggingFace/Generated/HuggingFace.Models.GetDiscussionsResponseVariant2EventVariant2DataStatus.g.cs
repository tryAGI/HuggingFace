
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant2DataStatus
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
    public static class GetDiscussionsResponseVariant2EventVariant2DataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant2DataStatus value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant2DataStatus.Closed => "closed",
                GetDiscussionsResponseVariant2EventVariant2DataStatus.Draft => "draft",
                GetDiscussionsResponseVariant2EventVariant2DataStatus.Merged => "merged",
                GetDiscussionsResponseVariant2EventVariant2DataStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant2DataStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetDiscussionsResponseVariant2EventVariant2DataStatus.Closed,
                "draft" => GetDiscussionsResponseVariant2EventVariant2DataStatus.Draft,
                "merged" => GetDiscussionsResponseVariant2EventVariant2DataStatus.Merged,
                "open" => GetDiscussionsResponseVariant2EventVariant2DataStatus.Open,
                _ => null,
            };
        }
    }
}