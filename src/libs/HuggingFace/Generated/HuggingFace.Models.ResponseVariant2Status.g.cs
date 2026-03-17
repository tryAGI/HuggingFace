
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2Status
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
    public static class ResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2Status value)
        {
            return value switch
            {
                ResponseVariant2Status.Draft => "draft",
                ResponseVariant2Status.Open => "open",
                ResponseVariant2Status.Closed => "closed",
                ResponseVariant2Status.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseVariant2Status.Draft,
                "open" => ResponseVariant2Status.Open,
                "closed" => ResponseVariant2Status.Closed,
                "merged" => ResponseVariant2Status.Merged,
                _ => null,
            };
        }
    }
}