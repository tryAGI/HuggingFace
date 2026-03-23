
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}