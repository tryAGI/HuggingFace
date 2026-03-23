
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDiscussionsStatusRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusRequestStatus value)
        {
            return value switch
            {
                CreateDiscussionsStatusRequestStatus.Closed => "closed",
                CreateDiscussionsStatusRequestStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CreateDiscussionsStatusRequestStatus.Closed,
                "open" => CreateDiscussionsStatusRequestStatus.Open,
                _ => null,
            };
        }
    }
}