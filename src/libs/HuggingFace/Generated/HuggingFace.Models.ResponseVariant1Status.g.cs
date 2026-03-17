
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1Status
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
    public static class ResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1Status value)
        {
            return value switch
            {
                ResponseVariant1Status.Draft => "draft",
                ResponseVariant1Status.Open => "open",
                ResponseVariant1Status.Closed => "closed",
                ResponseVariant1Status.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseVariant1Status.Draft,
                "open" => ResponseVariant1Status.Open,
                "closed" => ResponseVariant1Status.Closed,
                "merged" => ResponseVariant1Status.Merged,
                _ => null,
            };
        }
    }
}