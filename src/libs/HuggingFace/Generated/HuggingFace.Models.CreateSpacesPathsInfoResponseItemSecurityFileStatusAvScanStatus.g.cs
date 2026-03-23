
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}