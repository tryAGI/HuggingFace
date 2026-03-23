
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesLogsLogType
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesLogsLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLogsLogType value)
        {
            return value switch
            {
                GetSpacesLogsLogType.Build => "build",
                GetSpacesLogsLogType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLogsLogType? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetSpacesLogsLogType.Build,
                "run" => GetSpacesLogsLogType.Run,
                _ => null,
            };
        }
    }
}