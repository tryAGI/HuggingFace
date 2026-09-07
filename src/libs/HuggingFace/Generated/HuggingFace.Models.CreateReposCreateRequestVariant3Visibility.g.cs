
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
    /// </summary>
    public enum CreateReposCreateRequestVariant3Visibility
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
    public static class CreateReposCreateRequestVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant3Visibility value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant3Visibility.Private => "private",
                CreateReposCreateRequestVariant3Visibility.Protected => "protected",
                CreateReposCreateRequestVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateReposCreateRequestVariant3Visibility.Private,
                "protected" => CreateReposCreateRequestVariant3Visibility.Protected,
                "public" => CreateReposCreateRequestVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}