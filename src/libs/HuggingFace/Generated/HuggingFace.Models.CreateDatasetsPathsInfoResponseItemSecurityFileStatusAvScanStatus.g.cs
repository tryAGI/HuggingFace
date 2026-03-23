
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}