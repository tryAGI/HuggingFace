
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}