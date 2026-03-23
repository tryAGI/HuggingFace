
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}