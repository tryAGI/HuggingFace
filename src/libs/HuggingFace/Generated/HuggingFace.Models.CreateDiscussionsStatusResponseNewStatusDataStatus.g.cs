
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusResponseNewStatusDataStatus
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
    public static class CreateDiscussionsStatusResponseNewStatusDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusResponseNewStatusDataStatus value)
        {
            return value switch
            {
                CreateDiscussionsStatusResponseNewStatusDataStatus.Closed => "closed",
                CreateDiscussionsStatusResponseNewStatusDataStatus.Draft => "draft",
                CreateDiscussionsStatusResponseNewStatusDataStatus.Merged => "merged",
                CreateDiscussionsStatusResponseNewStatusDataStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusResponseNewStatusDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CreateDiscussionsStatusResponseNewStatusDataStatus.Closed,
                "draft" => CreateDiscussionsStatusResponseNewStatusDataStatus.Draft,
                "merged" => CreateDiscussionsStatusResponseNewStatusDataStatus.Merged,
                "open" => CreateDiscussionsStatusResponseNewStatusDataStatus.Open,
                _ => null,
            };
        }
    }
}