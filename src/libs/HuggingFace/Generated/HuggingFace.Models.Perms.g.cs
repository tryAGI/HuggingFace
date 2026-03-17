
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Perms
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
    public static class PermsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Perms value)
        {
            return value switch
            {
                Perms.Read => "read",
                Perms.Write => "write",
                Perms.Infer => "infer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Perms? ToEnum(string value)
        {
            return value switch
            {
                "read" => Perms.Read,
                "write" => Perms.Write,
                "infer" => Perms.Infer,
                _ => null,
            };
        }
    }
}