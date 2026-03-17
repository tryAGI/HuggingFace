
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewStatusDataStatus
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
    public static class ResponseNewStatusDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewStatusDataStatus value)
        {
            return value switch
            {
                ResponseNewStatusDataStatus.Draft => "draft",
                ResponseNewStatusDataStatus.Open => "open",
                ResponseNewStatusDataStatus.Closed => "closed",
                ResponseNewStatusDataStatus.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewStatusDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseNewStatusDataStatus.Draft,
                "open" => ResponseNewStatusDataStatus.Open,
                "closed" => ResponseNewStatusDataStatus.Closed,
                "merged" => ResponseNewStatusDataStatus.Merged,
                _ => null,
            };
        }
    }
}