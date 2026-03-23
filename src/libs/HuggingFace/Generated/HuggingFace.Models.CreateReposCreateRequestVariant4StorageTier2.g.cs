
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReposCreateRequestVariant4StorageTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReposCreateRequestVariant4StorageTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant4StorageTier2 value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant4StorageTier2.Large => "large",
                CreateReposCreateRequestVariant4StorageTier2.Medium => "medium",
                CreateReposCreateRequestVariant4StorageTier2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant4StorageTier2? ToEnum(string value)
        {
            return value switch
            {
                "large" => CreateReposCreateRequestVariant4StorageTier2.Large,
                "medium" => CreateReposCreateRequestVariant4StorageTier2.Medium,
                "small" => CreateReposCreateRequestVariant4StorageTier2.Small,
                _ => null,
            };
        }
    }
}