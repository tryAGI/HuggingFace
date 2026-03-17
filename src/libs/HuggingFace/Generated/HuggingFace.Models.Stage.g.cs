
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Stage
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Stage value)
        {
            return value switch
            {
                Stage.Completed => "COMPLETED",
                Stage.Canceled => "CANCELED",
                Stage.Error => "ERROR",
                Stage.Deleted => "DELETED",
                Stage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Stage? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => Stage.Completed,
                "CANCELED" => Stage.Canceled,
                "ERROR" => Stage.Error,
                "DELETED" => Stage.Deleted,
                "RUNNING" => Stage.Running,
                _ => null,
            };
        }
    }
}