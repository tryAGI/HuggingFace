
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}