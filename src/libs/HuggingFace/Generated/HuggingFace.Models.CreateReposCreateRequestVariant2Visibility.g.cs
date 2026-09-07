
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
    /// </summary>
    public enum CreateReposCreateRequestVariant2Visibility
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
    public static class CreateReposCreateRequestVariant2VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant2Visibility value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant2Visibility.Private => "private",
                CreateReposCreateRequestVariant2Visibility.Protected => "protected",
                CreateReposCreateRequestVariant2Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant2Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateReposCreateRequestVariant2Visibility.Private,
                "protected" => CreateReposCreateRequestVariant2Visibility.Protected,
                "public" => CreateReposCreateRequestVariant2Visibility.Public,
                _ => null,
            };
        }
    }
}