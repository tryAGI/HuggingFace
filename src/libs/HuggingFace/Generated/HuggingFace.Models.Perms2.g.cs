
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Perms2
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Infer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Perms2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Perms2 value)
        {
            return value switch
            {
                Perms2.Read => "read",
                Perms2.Write => "write",
                Perms2.Infer => "infer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Perms2? ToEnum(string value)
        {
            return value switch
            {
                "read" => Perms2.Read,
                "write" => Perms2.Write,
                "infer" => Perms2.Infer,
                _ => null,
            };
        }
    }
}