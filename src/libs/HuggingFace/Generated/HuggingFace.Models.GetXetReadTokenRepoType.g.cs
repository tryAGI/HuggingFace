
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetXetReadTokenRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetXetReadTokenRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetXetReadTokenRepoType value)
        {
            return value switch
            {
                GetXetReadTokenRepoType.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetXetReadTokenRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => GetXetReadTokenRepoType.Buckets,
                _ => null,
            };
        }
    }
}