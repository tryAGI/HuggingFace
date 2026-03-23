
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}