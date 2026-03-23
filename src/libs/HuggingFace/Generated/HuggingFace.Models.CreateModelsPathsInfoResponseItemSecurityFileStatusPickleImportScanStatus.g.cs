
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}