
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum Type5
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Type5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type5 value)
        {
            return value switch
            {
                Type5.All => "all",
                Type5.Dataset => "dataset",
                Type5.Model => "model",
                Type5.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type5? ToEnum(string value)
        {
            return value switch
            {
                "all" => Type5.All,
                "dataset" => Type5.Dataset,
                "model" => Type5.Model,
                "space" => Type5.Space,
                _ => null,
            };
        }
    }
}