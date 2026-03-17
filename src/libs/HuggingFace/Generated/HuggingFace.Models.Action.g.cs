
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Action
    {
        /// <summary>
        /// 
        /// </summary>
        Enable,
        /// <summary>
        /// 
        /// </summary>
        Disable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Action value)
        {
            return value switch
            {
                Action.Enable => "enable",
                Action.Disable => "disable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Action? ToEnum(string value)
        {
            return value switch
            {
                "enable" => Action.Enable,
                "disable" => Action.Disable,
                _ => null,
            };
        }
    }
}