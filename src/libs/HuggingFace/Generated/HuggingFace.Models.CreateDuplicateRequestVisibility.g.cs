
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDuplicateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDuplicateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDuplicateRequestVisibility value)
        {
            return value switch
            {
                CreateDuplicateRequestVisibility.Private => "private",
                CreateDuplicateRequestVisibility.Protected => "protected",
                CreateDuplicateRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDuplicateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateDuplicateRequestVisibility.Private,
                "protected" => CreateDuplicateRequestVisibility.Protected,
                "public" => CreateDuplicateRequestVisibility.Public,
                _ => null,
            };
        }
    }
}