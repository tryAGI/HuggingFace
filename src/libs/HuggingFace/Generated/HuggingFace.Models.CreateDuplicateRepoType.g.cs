
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDuplicateRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDuplicateRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDuplicateRepoType value)
        {
            return value switch
            {
                CreateDuplicateRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDuplicateRepoType? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => CreateDuplicateRepoType.Spaces,
                _ => null,
            };
        }
    }
}