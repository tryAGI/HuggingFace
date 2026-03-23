
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Caution => "caution",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Error => "error",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Queued => "queued",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Safe => "safe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Caution,
                "error" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Error,
                "queued" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Queued,
                "safe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}