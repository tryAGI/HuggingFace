
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort direction: 1 for ascending, -1 for descending<br/>
    /// Default Value: -1
    /// </summary>
    public enum GetKernelsDirection
    {
        /// <summary>
        /// 1 for ascending, -1 for descending
        /// </summary>
        Minus1,
        /// <summary>
        /// 1 for ascending, -1 for descending
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsDirection value)
        {
            return value switch
            {
                GetKernelsDirection.Minus1 => "-1",
                GetKernelsDirection.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsDirection? ToEnum(string value)
        {
            return value switch
            {
                "-1" => GetKernelsDirection.Minus1,
                "1" => GetKernelsDirection.x1,
                _ => null,
            };
        }
    }
}