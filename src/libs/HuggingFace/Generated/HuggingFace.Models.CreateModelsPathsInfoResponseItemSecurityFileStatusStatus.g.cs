
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}