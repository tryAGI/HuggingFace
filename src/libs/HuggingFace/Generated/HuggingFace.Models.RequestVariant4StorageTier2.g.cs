
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestVariant4StorageTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Small,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant4StorageTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant4StorageTier2 value)
        {
            return value switch
            {
                RequestVariant4StorageTier2.Small => "small",
                RequestVariant4StorageTier2.Medium => "medium",
                RequestVariant4StorageTier2.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant4StorageTier2? ToEnum(string value)
        {
            return value switch
            {
                "small" => RequestVariant4StorageTier2.Small,
                "medium" => RequestVariant4StorageTier2.Medium,
                "large" => RequestVariant4StorageTier2.Large,
                _ => null,
            };
        }
    }
}