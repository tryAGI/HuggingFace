
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseAuthAccessTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        God,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWhoamiV2ResponseAuthAccessTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseAuthAccessTokenRole value)
        {
            return value switch
            {
                GetWhoamiV2ResponseAuthAccessTokenRole.FineGrained => "fineGrained",
                GetWhoamiV2ResponseAuthAccessTokenRole.God => "god",
                GetWhoamiV2ResponseAuthAccessTokenRole.Read => "read",
                GetWhoamiV2ResponseAuthAccessTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseAuthAccessTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetWhoamiV2ResponseAuthAccessTokenRole.FineGrained,
                "god" => GetWhoamiV2ResponseAuthAccessTokenRole.God,
                "read" => GetWhoamiV2ResponseAuthAccessTokenRole.Read,
                "write" => GetWhoamiV2ResponseAuthAccessTokenRole.Write,
                _ => null,
            };
        }
    }
}