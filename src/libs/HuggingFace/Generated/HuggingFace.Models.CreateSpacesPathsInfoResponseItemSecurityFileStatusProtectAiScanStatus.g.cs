
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}