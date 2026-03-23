
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetXetWriteTokenRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetXetWriteTokenRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetXetWriteTokenRepoType value)
        {
            return value switch
            {
                GetXetWriteTokenRepoType.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetXetWriteTokenRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => GetXetWriteTokenRepoType.Buckets,
                _ => null,
            };
        }
    }
}