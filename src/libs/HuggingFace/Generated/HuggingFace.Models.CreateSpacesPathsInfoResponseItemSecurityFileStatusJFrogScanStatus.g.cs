
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}