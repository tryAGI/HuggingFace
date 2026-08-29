
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDuplicateStatusRepoType
    {
        /// <summary>
        ///
        /// </summary>
        Datasets,
        /// <summary>
        ///
        /// </summary>
        Models,
        /// <summary>
        ///
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDuplicateStatusRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDuplicateStatusRepoType value)
        {
            return value switch
            {
                GetDuplicateStatusRepoType.Datasets => "datasets",
                GetDuplicateStatusRepoType.Models => "models",
                GetDuplicateStatusRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDuplicateStatusRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => GetDuplicateStatusRepoType.Datasets,
                "models" => GetDuplicateStatusRepoType.Models,
                "spaces" => GetDuplicateStatusRepoType.Spaces,
                _ => null,
            };
        }
    }
}