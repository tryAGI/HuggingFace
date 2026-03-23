
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}