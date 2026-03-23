
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}