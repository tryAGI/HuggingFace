
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1EventVariant2DataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Merged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant1EventVariant2DataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant2DataStatus value)
        {
            return value switch
            {
                ResponseVariant1EventVariant2DataStatus.Draft => "draft",
                ResponseVariant1EventVariant2DataStatus.Open => "open",
                ResponseVariant1EventVariant2DataStatus.Closed => "closed",
                ResponseVariant1EventVariant2DataStatus.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1EventVariant2DataStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseVariant1EventVariant2DataStatus.Draft,
                "open" => ResponseVariant1EventVariant2DataStatus.Open,
                "closed" => ResponseVariant1EventVariant2DataStatus.Closed,
                "merged" => ResponseVariant1EventVariant2DataStatus.Merged,
                _ => null,
            };
        }
    }
}