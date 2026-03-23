
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}